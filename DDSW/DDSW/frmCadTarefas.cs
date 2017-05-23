using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace DDSW
{
    public partial class frmCadTarefas : Form
    {
        private int codproj;
        private int codtarefa;
        private bool alterar;
        public frmCadTarefas(int codproj)
        {
            InitializeComponent();
            this.codproj = codproj;
        }
        public frmCadTarefas(int codproj, int codtarefa)
        {
            InitializeComponent();
            this.codproj = codproj;
            this.codtarefa = codtarefa;
            btnexcluir.Visible = true;
            btnState.Visible = true;
            alterar = true;

            try
            {

                Connection Conn = new Connection();
                Conn.setQuery("select previsao, descr from tarefas where cod = " + codtarefa);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    dtpPrevisao.Value = Convert.ToDateTime(Reader["previsao"]);
                    txtdescricao.Text = Convert.ToString(Reader["descr"]);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            if (!alterar)
            {
                try
                {
                    Connection Conn = new Connection();
                    Conn.setQuery("insert into Tarefas(codproj, descr, previsao) values("+ codproj +", ' " + txtdescricao.Text + " ' , '" + dtpPrevisao.Value.Year +"/"+dtpPrevisao.Value.Month+"/"+dtpPrevisao.Value.Day+ "');");
                    Conn.executeNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!");
                    Conn.close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Connection Conn = new Connection();

                    Conn.setQuery("update tarefas set descr = '" + txtdescricao.Text + "', previsao = '" + dtpPrevisao.Value.Year + "/" + dtpPrevisao.Value.Month + "/" + dtpPrevisao.Value.Day + "' where cod = " + this.codtarefa);
                    Conn.executeNonQuery();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
            if (Application.OpenForms.OfType<frmTarefas>().FirstOrDefault() != null)
            {
                Application.OpenForms.OfType<frmTarefas>().FirstOrDefault().carregaTarefas();
            }
        }

        private void frmCadTarefas_Load(object sender, EventArgs e)
        {
             
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o estado dessa tarefa para 'pronto'?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DateTime Data = DateTime.Now;
                Connection Conn = new Connection();
                Conn.setQuery("update tarefas set done = '" + Data.Year + "/" + Data.Month + "/" + Data.Day + "' where cod = " + codtarefa);
                Conn.executeNonQuery();
                Conn.close();
            }
            if (Application.OpenForms.OfType<frmTarefas>().FirstOrDefault() != null)
            {
                Application.OpenForms.OfType<frmTarefas>().FirstOrDefault().carregaTarefas();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir esta tarefa?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Connection Conn = new Connection();
                    Conn.setQuery("delete from tarefas where cod = " + codtarefa);
                    Conn.executeNonQuery();
                    MessageBox.Show("Excluído com sucesso!");
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (Application.OpenForms.OfType<frmTarefas>().FirstOrDefault() != null)
            {
                Application.OpenForms.OfType<frmTarefas>().FirstOrDefault().carregaTarefas();
            }
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmFuncProj FuncTarefas = new frmFuncProj(codtarefa);
            FuncTarefas.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
            FuncTarefas.Show();

        }
    }
}
