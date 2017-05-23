namespace DDSW
{
    partial class frmListaProj
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
            this.dtgproj = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcontato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproj)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgproj
            // 
            this.dtgproj.AllowUserToAddRows = false;
            this.dtgproj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.codcontato,
            this.nome,
            this.Empresa});
            this.dtgproj.Location = new System.Drawing.Point(12, 12);
            this.dtgproj.Name = "dtgproj";
            this.dtgproj.Size = new System.Drawing.Size(665, 229);
            this.dtgproj.TabIndex = 1;
            this.dtgproj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproj_CellClick);
            this.dtgproj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproj_CellContentClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.Visible = false;
            // 
            // codcontato
            // 
            this.codcontato.HeaderText = "codcontato";
            this.codcontato.Name = "codcontato";
            this.codcontato.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Width = 300;
            // 
            // frmListaProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 265);
            this.Controls.Add(this.dtgproj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListaProj";
            this.Text = "frmListaProj";
            this.Load += new System.EventHandler(this.frmListaProj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgproj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgproj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
    }
}