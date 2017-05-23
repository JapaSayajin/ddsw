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
    public partial class frmListaFunc : Form
    {
        public frmListaFunc()
        {
            InitializeComponent();
        }

        public void carrega()
        {
            
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select * from func");
                Conn.executeReader();
                MySqlDataReader Reader =Conn.getReader();
                dtgfnc.Rows.Clear();
                while (Reader.Read())
                {
                    dtgfnc.Rows.Add(Reader["cod"], Reader["nome"], Reader["cpf"], Reader["email"]);
                }
                Conn.close();
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmListaFunc_Load(object sender, EventArgs e)
        {
            carrega();
        }

        private void dtgfnc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgfnc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int cod = Convert.ToInt32(dtgfnc.CurrentRow.Cells[0].Value);
            if (cod != 0)
            {
                frmEditFunc func = new frmEditFunc();
                func.MdiParent = Application.OpenForms.OfType<MDIddsw>().FirstOrDefault();
                func.Show();
                func.importa(cod);
            }
        }
    }
}
