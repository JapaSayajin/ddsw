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

namespace DDSW
{
    public partial class frmEditProj : Form
    {
        int cod;
        bool boolAlterar;
        private int codcontato;
        public frmEditProj()
        {
            InitializeComponent();
        }
        
        public void importaproj(int id)
        {
            boolAlterar = true;
            btntarefas.Visible = true;

            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select * from proj left join contato on contato.cod = proj.codcontato where proj.cod = " + id);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                clear();
                while (Reader.Read())
                {
                    cod = Convert.ToInt32(Reader["cod"]);
                    txtNome.Text = Convert.ToString(Reader["nome"]);
                    txtEmail.Text = Convert.ToString(Reader["email"]);
                    txtEmpresa.Text = Convert.ToString(Reader["empresa"]);
                    txtnomeproj.Text = Convert.ToString(Reader["nomeproj"]);
                    txtObs.Text = Convert.ToString(Reader["obs"]);
                    this.codcontato = Convert.ToInt16(Reader["codcontato"]);
                }
                btnSubmit.Text = "Atualizar";
                Conn.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void importacont(int id)
        {
            
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select * from contato where cod = " + id);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                clear();
                while (Reader.Read())
                {
                    cod = Convert.ToInt32(Reader["cod"]);
                    txtNome.Text = Convert.ToString(Reader["nome"]);
                    txtEmail.Text = Convert.ToString(Reader["email"]);
                    txtEmpresa.Text = Convert.ToString(Reader["empresa"]);
                }
                Conn.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmEditProj_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!boolAlterar)
            {
                try
                {
                    Connection Conn = new Connection();
                    Conn.setQuery("insert into proj(codcontato, nomeproj, obs) values(" + cod + ", '" + txtnomeproj.Text + "', '" + txtObs.Text + "')");
                    Conn.executeNonQuery();

                    Conn.setQuery("update contato set empresa = '" + txtEmpresa.Text + "', email = '" + txtEmail.Text + "' where cod = " + codcontato);
                    Conn.executeNonQuery();
                    Conn.close();
                    clear();
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
                    Conn.setQuery("update proj set nomeproj = '" + txtnomeproj.Text + "', obs ='" + txtObs.Text + "' where cod = " + cod);
                    Conn.executeNonQuery();

                    Conn.setQuery("update contato set empresa = '" + txtEmpresa.Text + "', email = '" + txtEmail.Text + "' where cod = " + codcontato);
                    Conn.executeNonQuery();
                    Conn.close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Application.OpenForms.OfType<frmListaProj>().FirstOrDefault() != null)
            {
                Application.OpenForms.OfType<frmListaProj>().FirstOrDefault().carrega() ;
            }
            this.Hide();

        }

        public static Form IsFormAlreadyOpen(Type FormType)
        {
            foreach (Form OpenForm in System.Windows.Forms.Application.OpenForms)
            {
                if (OpenForm.GetType() == FormType)
                    return OpenForm;
            }

            return null;
        }
        private void clear()
        {

            txtNome.Clear();
            txtEmail.Clear();
            txtEmpresa.Clear();
            txtObs.Clear();
            txtnomeproj.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (!boolAlterar)
            {
                try
                {
                    Connection Conn = new Connection();

                    Conn.setQuery("delete from contato where cod = " + cod);
                    Conn.executeNonQuery();
                    Conn.close();
                    this.Close();
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
                    Conn.setQuery("delete from proj where codcontato = " + cod);
                    Conn.executeNonQuery();
                    Conn.close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                Application.OpenForms.OfType<frmListaFunc>().FirstOrDefault().carrega();
           
        }

        private void btntarefas_Click(object sender, EventArgs e)
        {
            frmTarefas Tarefas = new frmTarefas(cod);
            Tarefas.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
            Tarefas.Show();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmFuncProj Func = new frmFuncProj(cod);
            Func.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
            Func.Show();
        }
    }
}
