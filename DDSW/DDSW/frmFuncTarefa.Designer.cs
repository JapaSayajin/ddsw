namespace DDSW
{
    partial class frmFuncTarefa
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
            this.dtgFuncTarefa = new System.Windows.Forms.DataGridView();
            this.Codfunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFuncTarefa
            // 
            this.dtgFuncTarefa.AllowUserToAddRows = false;
            this.dtgFuncTarefa.AllowUserToDeleteRows = false;
            this.dtgFuncTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncTarefa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codfunc,
            this.Nome,
            this.Cpf});
            this.dtgFuncTarefa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgFuncTarefa.Location = new System.Drawing.Point(12, 12);
            this.dtgFuncTarefa.Name = "dtgFuncTarefa";
            this.dtgFuncTarefa.ReadOnly = true;
            this.dtgFuncTarefa.Size = new System.Drawing.Size(483, 391);
            this.dtgFuncTarefa.TabIndex = 0;
            // 
            // Codfunc
            // 
            this.Codfunc.HeaderText = "CodFunc";
            this.Codfunc.Name = "Codfunc";
            this.Codfunc.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            // 
            // frmFuncTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 415);
            this.Controls.Add(this.dtgFuncTarefa);
            this.Name = "frmFuncTarefa";
            this.Text = "frmFuncTarefa";
            this.Load += new System.EventHandler(this.frmFuncTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncTarefa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFuncTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codfunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
    }
}