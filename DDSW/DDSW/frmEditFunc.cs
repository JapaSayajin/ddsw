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
    public partial class frmEditFunc : Form
    {
        int cod;
        bool alterar = false;
        

        public frmEditFunc()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtNome.Clear();
            mskCpf.Clear();
            txtCep.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtEmail.Clear();
            txtRG.Clear();

        }

        public void importa(int id)
        {
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select * from func where cod = " + id);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    cod = id;
                    txtCep.Text = Convert.ToString(Reader["cep"]);
                    txtComplemento.Text = Convert.ToString(Reader["comp"]);
                    mskCpf.Text = Convert.ToString(Reader["cpf"]);
                    txtEmail.Text = Convert.ToString(Reader["email"]);
                    txtNome.Text = Convert.ToString(Reader["nome"]);
                    txtNumero.Text = Convert.ToString(Reader["num"]);
                    txtRG.Text = Convert.ToString(Reader["rg"]);
                    btnexcluir.Visible = true;
                }
                alterar = true;
                Conn.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!alterar)
            {
                try
                {
                    Connection Conn = new Connection();

                    Conn.setQuery("insert into func(nome, cpf, cep, num,comp, email, rg) values('" + txtNome.Text + "', " + mskCpf.Text + ", " + txtCep.Text + ", '" + txtNumero.Text + "', '" + txtComplemento.Text + "', '" + txtEmail.Text + "', '" + txtRG.Text + "')");
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
                    Conn.setQuery("update func set nome = '" + txtNome.Text + "', cpf = " + mskCpf.Text + ", cep =  " + txtCep.Text + ", num = '" + txtNumero.Text + "', comp = '" + txtComplemento.Text + "', email = '" + txtEmail.Text + "', rg = '" + txtRG.Text + "' where cod = " + cod);
                    Conn.executeNonQuery();
                    Conn.close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Application.OpenForms.OfType<frmListaFunc>().FirstOrDefault() != null)
            {
                Application.OpenForms.OfType<frmListaFunc>().FirstOrDefault().carrega();
            }

            mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void frmEditFunc_Load(object sender, EventArgs e)
        {
            btnexcluir.Visible = false;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (alterar)
            {
                try
                {
                    Connection Conn = new Connection();
                    Conn.setQuery("delete from func where cod = " + cod);
                    Conn.executeNonQuery();
                    Conn.close();
                    Application.OpenForms.OfType<frmListaFunc>().FirstOrDefault().carrega();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Somente Numeros");
        }

        private void mskCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
