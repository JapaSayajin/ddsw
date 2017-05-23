namespace DDSW
{
    partial class frmListaFunc
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
            this.dtgfnc = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgfnc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgfnc
            // 
            this.dtgfnc.AllowUserToAddRows = false;
            this.dtgfnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgfnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.Nome,
            this.cpf,
            this.Email});
            this.dtgfnc.Location = new System.Drawing.Point(12, 12);
            this.dtgfnc.Name = "dtgfnc";
            this.dtgfnc.Size = new System.Drawing.Size(466, 229);
            this.dtgfnc.TabIndex = 0;
            this.dtgfnc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgfnc_CellClick);
            this.dtgfnc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgfnc_CellContentClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // cpf
            // 
            this.cpf.HeaderText = "Cpf";
            this.cpf.Name = "cpf";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // frmListaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this.dtgfnc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListaFunc";
            this.Text = "frmListaFunc";
            this.Load += new System.EventHandler(this.frmListaFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgfnc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgfnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}