namespace DDSW
{
    partial class MDIddsw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem,
            this.listaDeFuncionariosToolStripMenuItem,
            this.listaDeProjetosToolStripMenuItem,
            this.cadastroDeFuncionárioToolStripMenuItem,
            this.cadastroDeLoginToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(904, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.contatosToolStripMenuItem.Text = "Contatos";
            this.contatosToolStripMenuItem.Click += new System.EventHandler(this.contatosToolStripMenuItem_Click);
            // 
            // listaDeFuncionariosToolStripMenuItem
            // 
            this.listaDeFuncionariosToolStripMenuItem.Name = "listaDeFuncionariosToolStripMenuItem";
            this.listaDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.listaDeFuncionariosToolStripMenuItem.Text = "Lista de Funcionarios";
            this.listaDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.listaDeFuncionariosToolStripMenuItem_Click);
            // 
            // listaDeProjetosToolStripMenuItem
            // 
            this.listaDeProjetosToolStripMenuItem.Name = "listaDeProjetosToolStripMenuItem";
            this.listaDeProjetosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.listaDeProjetosToolStripMenuItem.Text = "Lista de projetos";
            this.listaDeProjetosToolStripMenuItem.Click += new System.EventHandler(this.listaDeProjetosToolStripMenuItem_Click);
            // 
            // cadastroDeFuncionárioToolStripMenuItem
            // 
            this.cadastroDeFuncionárioToolStripMenuItem.Name = "cadastroDeFuncionárioToolStripMenuItem";
            this.cadastroDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.cadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionário";
            this.cadastroDeFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFuncionárioToolStripMenuItem_Click);
            // 
            // cadastroDeLoginToolStripMenuItem
            // 
            this.cadastroDeLoginToolStripMenuItem.Name = "cadastroDeLoginToolStripMenuItem";
            this.cadastroDeLoginToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.cadastroDeLoginToolStripMenuItem.Text = "Cadastro de login";
            this.cadastroDeLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLoginToolStripMenuItem_Click);
            // 
            // MDIddsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIddsw";
            this.Text = "MDIddsw";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIddsw_FormClosed);
            this.Load += new System.EventHandler(this.MDIddsw_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLoginToolStripMenuItem;
    }
}



