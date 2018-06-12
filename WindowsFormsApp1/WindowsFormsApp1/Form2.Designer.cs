namespace WindowsFormsApp1
{
    partial class Form2
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
            this.labelClienteID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlterarE = new System.Windows.Forms.Button();
            this.LabelClienteName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCartaoCidadao = new System.Windows.Forms.Label();
            this.textBoxCartaoCidadao = new System.Windows.Forms.TextBox();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Location = new System.Drawing.Point(123, 29);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(18, 13);
            this.labelClienteID.TabIndex = 0;
            this.labelClienteID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // buttonAlterarE
            // 
            this.buttonAlterarE.Location = new System.Drawing.Point(108, 229);
            this.buttonAlterarE.Name = "buttonAlterarE";
            this.buttonAlterarE.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarE.TabIndex = 3;
            this.buttonAlterarE.Text = "Alterar";
            this.buttonAlterarE.UseVisualStyleBackColor = true;
            this.buttonAlterarE.Click += new System.EventHandler(this.buttonEliminarE_Click);
            // 
            // LabelClienteName
            // 
            this.LabelClienteName.AutoSize = true;
            this.LabelClienteName.Location = new System.Drawing.Point(31, 83);
            this.LabelClienteName.Name = "LabelClienteName";
            this.LabelClienteName.Size = new System.Drawing.Size(35, 13);
            this.LabelClienteName.TabIndex = 4;
            this.LabelClienteName.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(126, 80);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(135, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // labelCartaoCidadao
            // 
            this.labelCartaoCidadao.AutoSize = true;
            this.labelCartaoCidadao.Location = new System.Drawing.Point(31, 177);
            this.labelCartaoCidadao.Name = "labelCartaoCidadao";
            this.labelCartaoCidadao.Size = new System.Drawing.Size(80, 13);
            this.labelCartaoCidadao.TabIndex = 8;
            this.labelCartaoCidadao.Text = "Cartao Cidadao";
            // 
            // textBoxCartaoCidadao
            // 
            this.textBoxCartaoCidadao.Location = new System.Drawing.Point(126, 174);
            this.textBoxCartaoCidadao.Name = "textBoxCartaoCidadao";
            this.textBoxCartaoCidadao.Size = new System.Drawing.Size(135, 20);
            this.textBoxCartaoCidadao.TabIndex = 9;
            // 
            // dateTimeData
            // 
            this.dateTimeData.Location = new System.Drawing.Point(126, 130);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(135, 20);
            this.dateTimeData.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 291);
            this.Controls.Add(this.dateTimeData);
            this.Controls.Add(this.textBoxCartaoCidadao);
            this.Controls.Add(this.labelCartaoCidadao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelClienteName);
            this.Controls.Add(this.buttonAlterarE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClienteID);
            this.Name = "Form2";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClienteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlterarE;
        private System.Windows.Forms.Label LabelClienteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCartaoCidadao;
        private System.Windows.Forms.TextBox textBoxCartaoCidadao;
        private System.Windows.Forms.DateTimePicker dateTimeData;
    }
}