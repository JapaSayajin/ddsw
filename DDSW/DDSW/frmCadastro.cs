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
    public partial class frmCadastro : Form
    {
        private int nivacesso;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select func.cod as func_cod, users.cod as users_cod from func left join users on users.cod = func.cod where cpf = " + mskCpf.Text);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                Conn = new Connection();
                if (!Reader.Read())
                {
                    MessageBox.Show("Funcionário não cadastrado");
                }
                else
                {
                    if (Reader["users_cod"] == System.DBNull.Value)
                    {
                        System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtSenha.Text);
                        byte[] hash = md5.ComputeHash(inputBytes);
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        for (int i = 0; i < hash.Length; i++)
                        {
                            sb.Append(hash[i].ToString("X2"));
                        }
                        String crip = sb.ToString(); // Retorna senha criptografada 
                        if(rdoadm.Checked ) {
                            nivacesso = 1;
                        }
                        if (rdofunc.Checked)
                        {
                            nivacesso = 0;
                        }
                        Conn.setQuery("insert into users(cod, user, pass,  niv) values(" + Reader["func_cod"] + ", '" + txtLogin.Text + "', '" +  sb + "', " + nivacesso + ");");
                        Conn.executeNonQuery();
                        Reader.Close();
                        Conn.close();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        mskCpf.Clear();
                        txtConfirmarSenha.Clear();
                    }
                }

                mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
        
    }
}
