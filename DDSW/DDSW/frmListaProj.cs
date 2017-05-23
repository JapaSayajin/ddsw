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
    public partial class frmListaProj : Form
    {
        public frmListaProj()
        {
            InitializeComponent();
        }

        private void frmListaProj_Load(object sender, EventArgs e)
        {
            carrega();
        }

        public void carrega()
        {
            
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select * from proj left join contato on contato.cod = proj.codcontato");
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                dtgproj.Rows.Clear();
                while (Reader.Read())
                {

                    dtgproj.Rows.Add(Reader["Cod"], Reader["codcontato"], Reader["nomeproj"], Reader["empresa"]);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
    private void dtgproj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod = Convert.ToInt32(dtgproj.CurrentRow.Cells[0].Value);
            frmEditProj proj = new frmEditProj();
            proj.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
            proj.importaproj(cod);
            proj.Show();
        }

        private void dtgproj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
