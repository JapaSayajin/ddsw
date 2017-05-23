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
    public partial class frmContatos : Form
    {
        public static int id;
        int countcontato = 0;
        int countproj = 0;
        public frmContatos()
        {
            InitializeComponent();
        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            tmrRefresh.Enabled = true;
        }

        private void dtgContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgContatos.CurrentRow;
            if (row !=null)

            if (Convert.ToBoolean(row.Cells[0].Value))

            {
                frmEditProj proj = new frmEditProj();
                proj.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
                proj.Show();
                proj.importacont(Convert.ToInt32(row.Cells[0].Value));
                id = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void dtgContatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Carrega()
        {
            
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select contato.cod, contato.nome, contato.empresa, contato.email, contato.data, proj.codcontato as proj_codcontato from contato left join proj on proj.codcontato = contato.cod");
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                dtgContatos.Rows.Clear();
                while (Reader.Read())
                {
                    if ((Reader["proj_codcontato"]).ToString() == "")
                    {
                        dtgContatos.Rows.Add(Reader["cod"], Reader["nome"], Reader["empresa"], Convert.ToString(Reader["email"]), Convert.ToString(Reader["Data"]));

                    }
                }
                Reader.Close();
                Conn.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try {
                Connection Conn = new Connection();
                Conn.setQuery("select count(contato.cod) as contato, count(proj.codcontato) as proj from contato left join proj on proj.codcontato = contato.cod");
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    if (Convert.ToInt32(Reader["contato"]) > countcontato)
                    {
                        Carrega();
                    }
                    if (Convert.ToInt32(Reader["proj"]) > countproj)
                    {
                        Carrega();
                    }
                }
                countcontato = Convert.ToInt32(Reader["contato"]);
                countproj = Convert.ToInt32(Reader["proj"]);
                Reader.Close();
                Conn.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
