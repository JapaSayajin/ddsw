using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDSW
{
    public partial class MDIddsw : Form
    {
        private int childFormNumber = 0;
        public int nivacesso;

        public MDIddsw(int acesso)
        {
            InitializeComponent();
            this.nivacesso = acesso;
            if(nivacesso == 0)
            {
                cadastroDeFuncionárioToolStripMenuItem.Visible = false;
                cadastroDeLoginToolStripMenuItem.Visible = false;
                listaDeFuncionariosToolStripMenuItem.Visible = false;
            }
        }
        
              

        public void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContatos Contatos;
            if ((Contatos = (frmContatos)IsFormAlreadyOpen(typeof(frmContatos))) == null)
            { //Form isn't open so create one
                Contatos = new frmContatos();
                Contatos.MdiParent = this;
                Contatos.Show();
            }
            else
            { // Form is already open so bring it to the front
                Contatos.BringToFront();

            }
            
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

        private void MDIddsw_Load(object sender, EventArgs e)
        {

        }

        private void MDIddsw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<frmLogin>().FirstOrDefault().Close();

        }

        private void listaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFunc func;
            if ((func = (frmListaFunc)IsFormAlreadyOpen(typeof(frmListaFunc))) == null)
            { //Form isn't open so create one
                func = new frmListaFunc();
                func.MdiParent = this;
                func.Show();
            }
            else
            { // Form is already open so bring it to the front
                func.BringToFront();

            }
        }

        private void listaDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmListaProj proj;
            if ((proj = (frmListaProj)IsFormAlreadyOpen(typeof(frmListaProj))) == null)
            { //Form isn't open so create one
                proj = new frmListaProj();
                proj.MdiParent = this;
                proj.Show();
            }
            else
            { // Form is already open so bring it to the front
                proj.BringToFront();

            }
        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditFunc cadFunc = new frmEditFunc();
            cadFunc.MdiParent = this;
            cadFunc.Show();
        }

        private void cadastroDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro caduser;
            if ((caduser = (frmCadastro)IsFormAlreadyOpen(typeof(frmCadastro))) == null)
            { //Form isn't open so create one
                caduser = new frmCadastro();
                caduser.MdiParent = this;
                caduser.Show();
            }
            else
            { // Form is already open so bring it to the front
                caduser.BringToFront();

            }

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
