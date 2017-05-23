namespace DDSW
{
    partial class frmCadTarefas
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
            this.dtpPrevisao = new System.Windows.Forms.DateTimePicker();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lab25 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.btnState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpPrevisao
            // 
            this.dtpPrevisao.Location = new System.Drawing.Point(72, 12);
            this.dtpPrevisao.Name = "dtpPrevisao";
            this.dtpPrevisao.Size = new System.Drawing.Size(313, 20);
            this.dtpPrevisao.TabIndex = 55;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(240, 144);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(67, 26);
            this.btnexcluir.TabIndex = 53;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Visible = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(313, 144);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(72, 26);
            this.btnincluir.TabIndex = 52;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Previsão";
            // 
            // lab25
            // 
            this.lab25.AutoSize = true;
            this.lab25.Location = new System.Drawing.Point(8, 44);
            this.lab25.Name = "lab25";
            this.lab25.Size = new System.Drawing.Size(55, 13);
            this.lab25.TabIndex = 50;
            this.lab25.Text = "Descriçao";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(71, 41);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(314, 97);
            this.txtdescricao.TabIndex = 49;
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(167, 144);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(67, 26);
            this.btnState.TabIndex = 56;
            this.btnState.Text = "Estado";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Visible = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // frmCadTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.dtpPrevisao);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab25);
            this.Controls.Add(this.txtdescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadTarefas";
            this.Text = "frmCadTarefas";
            this.Load += new System.EventHandler(this.frmCadTarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPrevisao;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab25;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Button btnState;
    }
}