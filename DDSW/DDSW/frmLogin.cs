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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*try
            {*/

                Connection Conn = new Connection();

                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtSenha.Text);
                byte[] hash = md5.ComputeHash(inputBytes);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                String crip = sb.ToString(); // Retorna senha criptografada 

                Conn.setQuery("select * from users where  user = '" + txtLogin.Text + "' and pass = '" + sb + "'");
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    MDIddsw MDI = new MDIddsw(Convert.ToInt16(Reader["niv"]));
                
                MDI.Show();
                    this.Hide();
                }

                Conn.close();
            /*}
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível conectar no banco de dados" );
                MessageBox.Show(ex.Message);
            }*/
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
