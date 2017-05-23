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
    public partial class frmTarefas : Form
    {
        private int codproj;
        public frmTarefas(int cod)
        {
            InitializeComponent();
            this.codproj = cod;
            this.carregaTarefas();
        }

        public void carregaTarefas()
        {
            dtgtarefas.Rows.Clear();
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select tarefas.cod, tarefas.descr,tarefas.done,tarefas.previsao from tarefas where codproj = " + codproj + " order by tarefas.previsao");
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    DateTime previsao, termino;
                    previsao = Convert.ToDateTime(Reader["previsao"]);
                    termino = Convert.ToDateTime(Reader["done"]);
                    String terminoStr = termino.Day + "/" + termino.Month + "/" + termino.Year;
                    String result="Feito";
                    if (termino == DateTime.MinValue)
                    {
                        terminoStr = "";
                        TimeSpan ts = previsao - DateTime.Now;
                        int dias = Convert.ToInt16(ts.TotalDays);
                        if (dias < 0)
                        {
                            result = "Atrasado em " + dias + "dias";

                        }else if(dias>0)
                        {
                            result = "Restam " + dias + " dias";
                        }else
                        {
                            result = "No limite do prazo!";
                        }
                    }

                    dtgtarefas.Rows.Add(Reader["cod"], Reader["descr"], previsao.Day + "/" + previsao.Month + "/" + previsao.Year, terminoStr,result);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dttarefas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgtarefas.CurrentRow;
            if (row != null)
            {
                int cod = Convert.ToInt32(dtgtarefas.CurrentRow.Cells[0].Value);
                if (cod != 0)
                {
                    frmCadTarefas Cad = new frmCadTarefas(codproj, cod);
                    Cad.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
                    Cad.Show();
                }
            }
        }
        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadTarefas Cad = new frmCadTarefas(codproj);
            Cad.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
            Cad.Show();
        }

        private void frmTarefas_Load(object sender, EventArgs e)
        {

        }
    }
}

