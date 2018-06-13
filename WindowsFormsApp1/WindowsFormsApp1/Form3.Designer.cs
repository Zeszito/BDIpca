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
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.LabelNomeCliente = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelReserva = new System.Windows.Forms.Label();
            this.textBoxNomeStaff = new System.Windows.Forms.TextBox();
            this.textBoxServicoID = new System.Windows.Forms.TextBox();
            this.textBoxRececaoID = new System.Windows.Forms.TextBox();
            this.labelClienteID = new System.Windows.Forms.Label();
            this.labelServicoID = new System.Windows.Forms.Label();
            this.labelRececaoID = new System.Windows.Forms.Label();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelNomeStaff = new System.Windows.Forms.Label();
            this.labelHoraEStaff = new System.Windows.Forms.Label();
            this.textBoxHoraE = new System.Windows.Forms.TextBox();
            this.textBoxHoraS = new System.Windows.Forms.TextBox();
            this.labelHoraSStaff = new System.Windows.Forms.Label();
            this.textBoxClienteID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeData
            // 
            this.dateTimeData.Location = new System.Drawing.Point(124, 123);
            this.dateTimeData.Name = "dateTimeData";
            this.dateTimeData.Size = new System.Drawing.Size(135, 20);
            this.dateTimeData.TabIndex = 19;
            this.dateTimeData.Visible = false;
            // 
            // textBoxCartaoCidadao
            // 
            this.textBoxCartaoCidadao.Location = new System.Drawing.Point(124, 167);
            this.textBoxCartaoCidadao.Name = "textBoxCartaoCidadao";
            this.textBoxCartaoCidadao.Size = new System.Drawing.Size(135, 20);
            this.textBoxCartaoCidadao.TabIndex = 18;
            this.textBoxCartaoCidadao.Visible = false;
            // 
            // labelCartaoCidadao
            // 
            this.labelCartaoCidadao.AutoSize = true;
            this.labelCartaoCidadao.Location = new System.Drawing.Point(29, 170);
            this.labelCartaoCidadao.Name = "labelCartaoCidadao";
            this.labelCartaoCidadao.Size = new System.Drawing.Size(80, 13);
            this.labelCartaoCidadao.TabIndex = 17;
            this.labelCartaoCidadao.Text = "Cartao Cidadao";
            this.labelCartaoCidadao.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(106, 73);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(153, 20);
            this.textBoxNome.TabIndex = 16;
            this.textBoxNome.Visible = false;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(29, 123);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.labelDataNascimento.TabIndex = 15;
            this.labelDataNascimento.Text = "Data Nascimento";
            this.labelDataNascimento.Visible = false;
            // 
            // LabelNomeCliente
            // 
            this.LabelNomeCliente.AutoSize = true;
            this.LabelNomeCliente.Location = new System.Drawing.Point(29, 76);
            this.LabelNomeCliente.Name = "LabelNomeCliente";
            this.LabelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.LabelNomeCliente.TabIndex = 14;
            this.LabelNomeCliente.Text = "Nome";
            this.LabelNomeCliente.Visible = false;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(106, 222);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 13;
            this.btnCriar.Text = "Adicionar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Visible = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            this.label1.Visible = false;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(64, 24);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(138, 16);
            this.labelCliente.TabIndex = 11;
            this.labelCliente.Text = "Informação do Cliente";
            this.labelCliente.Visible = false;
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserva.Location = new System.Drawing.Point(64, 24);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(149, 16);
            this.labelReserva.TabIndex = 20;
            this.labelReserva.Text = "Informação da Reserva";
            this.labelReserva.Visible = false;
            // 
            // textBoxNomeStaff
            // 
            this.textBoxNomeStaff.Location = new System.Drawing.Point(106, 73);
            this.textBoxNomeStaff.Name = "textBoxNomeStaff";
            this.textBoxNomeStaff.Size = new System.Drawing.Size(153, 20);
            this.textBoxNomeStaff.TabIndex = 21;
            this.textBoxNomeStaff.Visible = false;
            // 
            // textBoxServicoID
            // 
            this.textBoxServicoID.Location = new System.Drawing.Point(106, 123);
            this.textBoxServicoID.Name = "textBoxServicoID";
            this.textBoxServicoID.Size = new System.Drawing.Size(153, 20);
            this.textBoxServicoID.TabIndex = 22;
            this.textBoxServicoID.Visible = false;
            // 
            // textBoxRececaoID
            // 
            this.textBoxRececaoID.Location = new System.Drawing.Point(106, 167);
            this.textBoxRececaoID.Name = "textBoxRececaoID";
            this.textBoxRececaoID.Size = new System.Drawing.Size(153, 20);
            this.textBoxRececaoID.TabIndex = 23;
            this.textBoxRececaoID.Visible = false;
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Location = new System.Drawing.Point(29, 76);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(53, 13);
            this.labelClienteID.TabIndex = 24;
            this.labelClienteID.Text = "Cliente ID";
            this.labelClienteID.Visible = false;
            // 
            // labelServicoID
            // 
            this.labelServicoID.AutoSize = true;
            this.labelServicoID.Location = new System.Drawing.Point(29, 126);
            this.labelServicoID.Name = "labelServicoID";
            this.labelServicoID.Size = new System.Drawing.Size(57, 13);
            this.labelServicoID.TabIndex = 25;
            this.labelServicoID.Text = "Serviço ID";
            this.labelServicoID.Visible = false;
            // 
            // labelRececaoID
            // 
            this.labelRececaoID.AutoSize = true;
            this.labelRececaoID.Location = new System.Drawing.Point(29, 170);
            this.labelRececaoID.Name = "labelRececaoID";
            this.labelRececaoID.Size = new System.Drawing.Size(65, 13);
            this.labelRececaoID.TabIndex = 26;
            this.labelRececaoID.Text = "Receção ID";
            this.labelRececaoID.Visible = false;
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaff.Location = new System.Drawing.Point(64, 24);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(172, 16);
            this.labelStaff.TabIndex = 27;
            this.labelStaff.Text = "Informação do Trabalhador";
            this.labelStaff.Visible = false;
            // 
            // labelNomeStaff
            // 
            this.labelNomeStaff.AutoSize = true;
            this.labelNomeStaff.Location = new System.Drawing.Point(29, 76);
            this.labelNomeStaff.Name = "labelNomeStaff";
            this.labelNomeStaff.Size = new System.Drawing.Size(35, 13);
            this.labelNomeStaff.TabIndex = 28;
            this.labelNomeStaff.Text = "Nome";
            this.labelNomeStaff.Visible = false;
            // 
            // labelHoraEStaff
            // 
            this.labelHoraEStaff.AutoSize = true;
            this.labelHoraEStaff.Location = new System.Drawing.Point(29, 126);
            this.labelHoraEStaff.Name = "labelHoraEStaff";
            this.labelHoraEStaff.Size = new System.Drawing.Size(70, 13);
            this.labelHoraEStaff.TabIndex = 29;
            this.labelHoraEStaff.Text = "Hora Entrada";
            this.labelHoraEStaff.Visible = false;
            // 
            // textBoxHoraE
            // 
            this.textBoxHoraE.Location = new System.Drawing.Point(105, 123);
            this.textBoxHoraE.Name = "textBoxHoraE";
            this.textBoxHoraE.Size = new System.Drawing.Size(153, 20);
            this.textBoxHoraE.TabIndex = 30;
            this.textBoxHoraE.Visible = false;
            // 
            // textBoxHoraS
            // 
            this.textBoxHoraS.Location = new System.Drawing.Point(106, 167);
            this.textBoxHoraS.Name = "textBoxHoraS";
            this.textBoxHoraS.Size = new System.Drawing.Size(153, 20);
            this.textBoxHoraS.TabIndex = 31;
            this.textBoxHoraS.Visible = false;
            // 
            // labelHoraSStaff
            // 
            this.labelHoraSStaff.AutoSize = true;
            this.labelHoraSStaff.Location = new System.Drawing.Point(29, 170);
            this.labelHoraSStaff.Name = "labelHoraSStaff";
            this.labelHoraSStaff.Size = new System.Drawing.Size(62, 13);
            this.labelHoraSStaff.TabIndex = 32;
            this.labelHoraSStaff.Text = "Hora Saída";
            this.labelHoraSStaff.Visible = false;
            // 
            // textBoxClienteID
            // 
            this.textBoxClienteID.Location = new System.Drawing.Point(105, 73);
            this.textBoxClienteID.Name = "textBoxClienteID";
            this.textBoxClienteID.Size = new System.Drawing.Size(153, 20);
            this.textBoxClienteID.TabIndex = 33;
            this.textBoxClienteID.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 280);
            this.Controls.Add(this.textBoxClienteID);
            this.Controls.Add(this.labelHoraSStaff);
            this.Controls.Add(this.textBoxHoraS);
            this.Controls.Add(this.labelHoraEStaff);
            this.Controls.Add(this.labelStaff);
            this.Controls.Add(this.labelRececaoID);
            this.Controls.Add(this.labelServicoID);
            this.Controls.Add(this.textBoxRececaoID);
            this.Controls.Add(this.labelReserva);
            this.Controls.Add(this.dateTimeData);
            this.Controls.Add(this.textBoxCartaoCidadao);
            this.Controls.Add(this.labelCartaoCidadao);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNomeStaff);
            this.Controls.Add(this.labelNomeStaff);
            this.Controls.Add(this.labelClienteID);
            this.Controls.Add(this.textBoxHoraE);
            this.Controls.Add(this.textBoxServicoID);
            this.Controls.Add(this.LabelNomeCliente);
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
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label LabelNomeCliente;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.TextBox textBoxNomeStaff;
        private System.Windows.Forms.TextBox textBoxServicoID;
        private System.Windows.Forms.TextBox textBoxRececaoID;
        private System.Windows.Forms.Label labelClienteID;
        private System.Windows.Forms.Label labelServicoID;
        private System.Windows.Forms.Label labelRececaoID;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Label labelNomeStaff;
        private System.Windows.Forms.Label labelHoraEStaff;
        private System.Windows.Forms.TextBox textBoxHoraE;
        private System.Windows.Forms.TextBox textBoxHoraS;
        private System.Windows.Forms.Label labelHoraSStaff;
        private System.Windows.Forms.TextBox textBoxClienteID;
    }
}