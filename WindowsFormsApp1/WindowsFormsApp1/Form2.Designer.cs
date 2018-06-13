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
            this.textBoxClienteID = new System.Windows.Forms.TextBox();
            this.labelHoraSStaff = new System.Windows.Forms.Label();
            this.textBoxHoraS = new System.Windows.Forms.TextBox();
            this.textBoxHoraE = new System.Windows.Forms.TextBox();
            this.labelHoraEStaff = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelRececaoID = new System.Windows.Forms.Label();
            this.labelServicoID = new System.Windows.Forms.Label();
            this.labelClienteID = new System.Windows.Forms.Label();
            this.textBoxRececaoID = new System.Windows.Forms.TextBox();
            this.textBoxServicoID = new System.Windows.Forms.TextBox();
            this.labelReserva = new System.Windows.Forms.Label();
            this.dateTimeData = new System.Windows.Forms.DateTimePicker();
            this.textBoxCartaoCidadao = new System.Windows.Forms.TextBox();
            this.labelCartaoCidadao = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxClienteID
            // 
            this.textBoxClienteID.Location = new System.Drawing.Point(112, 84);
            this.textBoxClienteID.Name = "textBoxClienteID";
            this.textBoxClienteID.Size = new System.Drawing.Size(153, 20);
            this.textBoxClienteID.TabIndex = 56;
            this.textBoxClienteID.Visible = false;
            // 
            // labelHoraSStaff
            // 
            this.labelHoraSStaff.AutoSize = true;
            this.labelHoraSStaff.Location = new System.Drawing.Point(36, 181);
            this.labelHoraSStaff.Name = "labelHoraSStaff";
            this.labelHoraSStaff.Size = new System.Drawing.Size(62, 13);
            this.labelHoraSStaff.TabIndex = 55;
            this.labelHoraSStaff.Text = "Hora Saída";
            this.labelHoraSStaff.Visible = false;
            // 
            // textBoxHoraS
            // 
            this.textBoxHoraS.Location = new System.Drawing.Point(113, 178);
            this.textBoxHoraS.Name = "textBoxHoraS";
            this.textBoxHoraS.Size = new System.Drawing.Size(153, 20);
            this.textBoxHoraS.TabIndex = 54;
            this.textBoxHoraS.Visible = false;
            // 
            // textBoxHoraE
            // 
            this.textBoxHoraE.Location = new System.Drawing.Point(113, 134);
            this.textBoxHoraE.Name = "textBoxHoraE";
            this.textBoxHoraE.Size = new System.Drawing.Size(153, 20);
            this.textBoxHoraE.TabIndex = 53;
            this.textBoxHoraE.Visible = false;
            // 
            // labelHoraEStaff
            // 
            this.labelHoraEStaff.AutoSize = true;
            this.labelHoraEStaff.Location = new System.Drawing.Point(37, 137);
            this.labelHoraEStaff.Name = "labelHoraEStaff";
            this.labelHoraEStaff.Size = new System.Drawing.Size(70, 13);
            this.labelHoraEStaff.TabIndex = 52;
            this.labelHoraEStaff.Text = "Hora Entrada";
            this.labelHoraEStaff.Visible = false;
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaff.Location = new System.Drawing.Point(71, 35);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(172, 16);
            this.labelStaff.TabIndex = 50;
            this.labelStaff.Text = "Informação do Trabalhador";
            this.labelStaff.Visible = false;
            // 
            // labelRececaoID
            // 
            this.labelRececaoID.AutoSize = true;
            this.labelRececaoID.Location = new System.Drawing.Point(36, 181);
            this.labelRececaoID.Name = "labelRececaoID";
            this.labelRececaoID.Size = new System.Drawing.Size(65, 13);
            this.labelRececaoID.TabIndex = 49;
            this.labelRececaoID.Text = "Receção ID";
            this.labelRececaoID.Visible = false;
            // 
            // labelServicoID
            // 
            this.labelServicoID.AutoSize = true;
            this.labelServicoID.Location = new System.Drawing.Point(36, 137);
            this.labelServicoID.Name = "labelServicoID";
            this.labelServicoID.Size = new System.Drawing.Size(57, 13);
            this.labelServicoID.TabIndex = 48;
            this.labelServicoID.Text = "Serviço ID";
            this.labelServicoID.Visible = false;
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Location = new System.Drawing.Point(36, 87);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(53, 13);
            this.labelClienteID.TabIndex = 47;
            this.labelClienteID.Text = "Cliente ID";
            this.labelClienteID.Visible = false;
            // 
            // textBoxRececaoID
            // 
            this.textBoxRececaoID.Location = new System.Drawing.Point(113, 178);
            this.textBoxRececaoID.Name = "textBoxRececaoID";
            this.textBoxRececaoID.Size = new System.Drawing.Size(153, 20);
            this.textBoxRececaoID.TabIndex = 46;
            this.textBoxRececaoID.Visible = false;
            // 
            // textBoxServicoID
            // 
            this.textBoxServicoID.Location = new System.Drawing.Point(113, 134);
            this.textBoxServicoID.Name = "textBoxServicoID";
            this.textBoxServicoID.Size = new System.Drawing.Size(153, 20);
            this.textBoxServicoID.TabIndex = 45;
            this.textBoxServicoID.Visible = false;
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserva.Location = new System.Drawing.Point(71, 35);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(149, 16);
            this.labelReserva.TabIndex = 43;
            this.labelReserva.Text = "Informação da Reserva";
            this.labelReserva.Visible = false;
            // 
            // dateTimeData
            // 
            this.dateTimeData.Location = new System.Drawing.Point(131, 134);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(135, 20);
            this.dateTimeData.TabIndex = 42;
            this.dateTimeData.Visible = false;
            // 
            // textBoxCartaoCidadao
            // 
            this.textBoxCartaoCidadao.Location = new System.Drawing.Point(131, 178);
            this.textBoxCartaoCidadao.Name = "textBoxCartaoCidadao";
            this.textBoxCartaoCidadao.Size = new System.Drawing.Size(135, 20);
            this.textBoxCartaoCidadao.TabIndex = 41;
            this.textBoxCartaoCidadao.Visible = false;
            // 
            // labelCartaoCidadao
            // 
            this.labelCartaoCidadao.AutoSize = true;
            this.labelCartaoCidadao.Location = new System.Drawing.Point(36, 181);
            this.labelCartaoCidadao.Name = "labelCartaoCidadao";
            this.labelCartaoCidadao.Size = new System.Drawing.Size(80, 13);
            this.labelCartaoCidadao.TabIndex = 40;
            this.labelCartaoCidadao.Text = "Cartao Cidadao";
            this.labelCartaoCidadao.Visible = false;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(36, 134);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.labelDataNascimento.TabIndex = 38;
            this.labelDataNascimento.Text = "Data Nascimento";
            this.labelDataNascimento.Visible = false;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(36, 87);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 37;
            this.labelNomeCliente.Text = "Nome";
            this.labelNomeCliente.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(113, 233);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 36;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 35;
            this.label1.Visible = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(71, 35);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(138, 16);
            this.labelCliente.TabIndex = 34;
            this.labelCliente.Text = "Informação do Cliente";
            this.labelCliente.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(113, 84);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(153, 20);
            this.textBoxNome.TabIndex = 39;
            this.textBoxNome.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 291);
            this.Controls.Add(this.labelHoraSStaff);
            this.Controls.Add(this.textBoxHoraS);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelRececaoID);
            this.Controls.Add(this.labelServicoID);
            this.Controls.Add(this.textBoxRececaoID);
            this.Controls.Add(this.textBoxServicoID);
            this.Controls.Add(this.labelReserva);
            this.Controls.Add(this.dateTimeData);
            this.Controls.Add(this.textBoxCartaoCidadao);
            this.Controls.Add(this.labelCartaoCidadao);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelHoraEStaff);
            this.Controls.Add(this.textBoxClienteID);
            this.Controls.Add(this.textBoxHoraE);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.labelClienteID);
            this.Name = "Form2";
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClienteID;
        private System.Windows.Forms.Label labelHoraSStaff;
        private System.Windows.Forms.TextBox textBoxHoraS;
        private System.Windows.Forms.TextBox textBoxHoraE;
        private System.Windows.Forms.Label labelHoraEStaff;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label labelRececaoID;
        private System.Windows.Forms.Label labelServicoID;
        private System.Windows.Forms.Label labelClienteID;
        private System.Windows.Forms.TextBox textBoxRececaoID;
        private System.Windows.Forms.TextBox textBoxServicoID;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.DateTimePicker dateTimeData;
        private System.Windows.Forms.TextBox textBoxCartaoCidadao;
        private System.Windows.Forms.Label labelCartaoCidadao;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}