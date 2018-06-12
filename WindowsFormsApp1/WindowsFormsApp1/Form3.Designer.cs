namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.textBoxCartaoCidadao = new System.Windows.Forms.TextBox();
            this.labelCartaoCidadao = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNomeCliente = new System.Windows.Forms.Label();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGenerico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeData
            // 
            this.dateTimeData.Location = new System.Drawing.Point(124, 123);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(135, 20);
            this.dateTimeData.TabIndex = 19;
            // 
            // textBoxCartaoCidadao
            // 
            this.textBoxCartaoCidadao.Location = new System.Drawing.Point(124, 167);
            this.textBoxCartaoCidadao.Name = "textBoxCartaoCidadao";
            this.textBoxCartaoCidadao.Size = new System.Drawing.Size(135, 20);
            this.textBoxCartaoCidadao.TabIndex = 18;
            // 
            // labelCartaoCidadao
            // 
            this.labelCartaoCidadao.AutoSize = true;
            this.labelCartaoCidadao.Location = new System.Drawing.Point(29, 170);
            this.labelCartaoCidadao.Name = "labelCartaoCidadao";
            this.labelCartaoCidadao.Size = new System.Drawing.Size(80, 13);
            this.labelCartaoCidadao.TabIndex = 17;
            this.labelCartaoCidadao.Text = "Cartao Cidadao";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(106, 73);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(153, 20);
            this.textBoxNome.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Nascimento";
            // 
            // LabelNomeCliente
            // 
            this.LabelNomeCliente.AutoSize = true;
            this.LabelNomeCliente.Location = new System.Drawing.Point(29, 76);
            this.LabelNomeCliente.Name = "LabelNomeCliente";
            this.LabelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.LabelNomeCliente.TabIndex = 14;
            this.LabelNomeCliente.Text = "Nome";
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.Location = new System.Drawing.Point(106, 222);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCriarCliente.TabIndex = 13;
            this.btnCriarCliente.Text = "Adicionar";
            this.btnCriarCliente.UseVisualStyleBackColor = true;
            this.btnCriarCliente.Click += new System.EventHandler(this.btnCriarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // labelGenerico
            // 
            this.labelGenerico.AutoSize = true;
            this.labelGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerico.Location = new System.Drawing.Point(64, 24);
            this.labelGenerico.Name = "labelGenerico";
            this.labelGenerico.Size = new System.Drawing.Size(138, 16);
            this.labelGenerico.TabIndex = 11;
            this.labelGenerico.Text = "Informação do Cliente";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 280);
            this.Controls.Add(this.dateTimeData);
            this.Controls.Add(this.textBoxCartaoCidadao);
            this.Controls.Add(this.labelCartaoCidadao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelNomeCliente);
            this.Controls.Add(this.btnCriarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGenerico);
            this.Name = "Form3";
            this.Text = "Criar";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeData;
        private System.Windows.Forms.TextBox textBoxCartaoCidadao;
        private System.Windows.Forms.Label labelCartaoCidadao;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNomeCliente;
        private System.Windows.Forms.Button btnCriarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGenerico;
    }
}