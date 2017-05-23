namespace DDSW
{
    partial class frmTarefas
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
            this.dtgtarefas = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Término = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgtarefas
            // 
            this.dtgtarefas.AllowUserToAddRows = false;
            this.dtgtarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.descricao,
            this.Previsao,
            this.Término,
            this.Status});
            this.dtgtarefas.Location = new System.Drawing.Point(12, 12);
            this.dtgtarefas.Name = "dtgtarefas";
            this.dtgtarefas.ReadOnly = true;
            this.dtgtarefas.Size = new System.Drawing.Size(466, 229);
            this.dtgtarefas.TabIndex = 2;
            this.dtgtarefas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dttarefas_CellClick);
            // 
            // cod
            // 
            this.cod.HeaderText = "cod";
            this.cod.Name = "cod";
            this.cod.Visible = false;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            // 
            // Previsao
            // 
            this.Previsao.HeaderText = "Previsao";
            this.Previsao.Name = "Previsao";
            // 
            // Término
            // 
            this.Término.HeaderText = "Término";
            this.Término.Name = "Término";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(403, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 278);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtgtarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTarefas";
            this.Text = "FrmTarefas";
            this.Load += new System.EventHandler(this.frmTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgtarefas;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previsao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Término;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}