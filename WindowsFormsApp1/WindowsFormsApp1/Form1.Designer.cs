namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonServiços = new System.Windows.Forms.Button();
            this.buttonVinicultura = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonReservas = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.buttonFILL = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.CurrentWindow = new System.Windows.Forms.Label();
            this.window = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.listBoxCCClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.textRececaoID = new System.Windows.Forms.TextBox();
            this.labelRececaoID = new System.Windows.Forms.Label();
            this.buttonReservar = new System.Windows.Forms.Button();
            this.textServicoID = new System.Windows.Forms.TextBox();
            this.labelServicoID = new System.Windows.Forms.Label();
            this.labelClienteID = new System.Windows.Forms.Label();
            this.textClienteID = new System.Windows.Forms.TextBox();
            this.listBoxIDClientes = new System.Windows.Forms.ListBox();
            this.listBoxNomeClientes = new System.Windows.Forms.ListBox();
            this.listBoxNascClientes = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.window.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(62, 420);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Gray;
            this.sidePanel.Controls.Add(this.textName);
            this.sidePanel.Controls.Add(this.textID);
            this.sidePanel.Controls.Add(this.buttonServiços);
            this.sidePanel.Controls.Add(this.buttonVinicultura);
            this.sidePanel.Controls.Add(this.buttonStaff);
            this.sidePanel.Controls.Add(this.buttonLogIn);
            this.sidePanel.Controls.Add(this.buttonClientes);
            this.sidePanel.Controls.Add(this.buttonReservas);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 450);
            this.sidePanel.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(112, 393);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(53, 20);
            this.textName.TabIndex = 7;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(23, 394);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(52, 20);
            this.textID.TabIndex = 6;
            // 
            // buttonServiços
            // 
            this.buttonServiços.BackColor = System.Drawing.Color.Gray;
            this.buttonServiços.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonServiços.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServiços.Location = new System.Drawing.Point(0, 316);
            this.buttonServiços.Name = "buttonServiços";
            this.buttonServiços.Size = new System.Drawing.Size(200, 65);
            this.buttonServiços.TabIndex = 5;
            this.buttonServiços.Text = "Serviços";
            this.buttonServiços.UseVisualStyleBackColor = false;
            this.buttonServiços.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.buttonServiços.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.buttonServiços.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // buttonVinicultura
            // 
            this.buttonVinicultura.BackColor = System.Drawing.Color.Gray;
            this.buttonVinicultura.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVinicultura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinicultura.Location = new System.Drawing.Point(0, 251);
            this.buttonVinicultura.Name = "buttonVinicultura";
            this.buttonVinicultura.Size = new System.Drawing.Size(200, 65);
            this.buttonVinicultura.TabIndex = 4;
            this.buttonVinicultura.Text = "Vinicultura";
            this.buttonVinicultura.UseVisualStyleBackColor = false;
            this.buttonVinicultura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.buttonVinicultura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.buttonVinicultura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.Gray;
            this.buttonStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaff.Location = new System.Drawing.Point(0, 186);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(200, 65);
            this.buttonStaff.TabIndex = 3;
            this.buttonStaff.Text = "Staff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.buttonStaff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.buttonStaff.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.Gray;
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Location = new System.Drawing.Point(0, 121);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(200, 65);
            this.buttonClientes.TabIndex = 2;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            this.buttonClientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.buttonClientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.buttonClientes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // buttonReservas
            // 
            this.buttonReservas.BackColor = System.Drawing.Color.Gray;
            this.buttonReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReservas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservas.Location = new System.Drawing.Point(0, 56);
            this.buttonReservas.Name = "buttonReservas";
            this.buttonReservas.Size = new System.Drawing.Size(200, 65);
            this.buttonReservas.TabIndex = 1;
            this.buttonReservas.Text = "Reservas";
            this.buttonReservas.UseVisualStyleBackColor = false;
            this.buttonReservas.Click += new System.EventHandler(this.buttonReservas_Click);
            this.buttonReservas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.buttonReservas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.buttonReservas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.DimGray;
            this.logoPanel.Controls.Add(this.r);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 56);
            this.logoPanel.TabIndex = 0;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.r.Location = new System.Drawing.Point(47, 18);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(62, 20);
            this.r.TabIndex = 0;
            this.r.Text = "Quinta";
            this.r.Click += new System.EventHandler(this.label1_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkGray;
            this.headerPanel.Controls.Add(this.buttonFILL);
            this.headerPanel.Controls.Add(this.Minimize);
            this.headerPanel.Controls.Add(this.Exit);
            this.headerPanel.Controls.Add(this.CurrentWindow);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(200, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(600, 56);
            this.headerPanel.TabIndex = 2;
            // 
            // buttonFILL
            // 
            this.buttonFILL.Location = new System.Drawing.Point(302, 18);
            this.buttonFILL.Name = "buttonFILL";
            this.buttonFILL.Size = new System.Drawing.Size(75, 23);
            this.buttonFILL.TabIndex = 8;
            this.buttonFILL.Text = "FILL";
            this.buttonFILL.UseVisualStyleBackColor = true;
            this.buttonFILL.Click += new System.EventHandler(this.buttonFILL_Click);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Gray;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minimize.Location = new System.Drawing.Point(549, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(15, 20);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Gray;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(570, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 20);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CurrentWindow
            // 
            this.CurrentWindow.AutoSize = true;
            this.CurrentWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CurrentWindow.Location = new System.Drawing.Point(36, 18);
            this.CurrentWindow.Name = "CurrentWindow";
            this.CurrentWindow.Size = new System.Drawing.Size(62, 20);
            this.CurrentWindow.TabIndex = 1;
            this.CurrentWindow.Text = "Quinta";
            // 
            // window
            // 
            this.window.Controls.Add(this.buttonEliminar);
            this.window.Controls.Add(this.buttonAlterar);
            this.window.Controls.Add(this.listBoxCCClientes);
            this.window.Controls.Add(this.label1);
            this.window.Controls.Add(this.labelClientes);
            this.window.Controls.Add(this.textRececaoID);
            this.window.Controls.Add(this.labelRececaoID);
            this.window.Controls.Add(this.buttonReservar);
            this.window.Controls.Add(this.textServicoID);
            this.window.Controls.Add(this.labelServicoID);
            this.window.Controls.Add(this.labelClienteID);
            this.window.Controls.Add(this.textClienteID);
            this.window.Controls.Add(this.listBoxIDClientes);
            this.window.Controls.Add(this.listBoxNomeClientes);
            this.window.Controls.Add(this.listBoxNascClientes);
            this.window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.window.Location = new System.Drawing.Point(200, 56);
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(600, 394);
            this.window.TabIndex = 3;
            this.window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.window_MouseDown);
            this.window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_MouseMove);
            this.window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.window_MouseUp);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(200, 318);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 23);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar Cliente";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(66, 318);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(89, 23);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar Cliente";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // listBoxCCClientes
            // 
            this.listBoxCCClientes.FormattingEnabled = true;
            this.listBoxCCClientes.Location = new System.Drawing.Point(374, 47);
            this.listBoxCCClientes.Name = "listBoxCCClientes";
            this.listBoxCCClientes.Size = new System.Drawing.Size(103, 251);
            this.listBoxCCClientes.TabIndex = 11;
            this.listBoxCCClientes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clientes";
            this.label1.Visible = false;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(37, 28);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(66, 20);
            this.labelClientes.TabIndex = 8;
            this.labelClientes.Text = "Clientes";
            this.labelClientes.Visible = false;
            // 
            // textRececaoID
            // 
            this.textRececaoID.Location = new System.Drawing.Point(148, 138);
            this.textRececaoID.Name = "textRececaoID";
            this.textRececaoID.Size = new System.Drawing.Size(100, 20);
            this.textRececaoID.TabIndex = 6;
            this.textRececaoID.Visible = false;
            // 
            // labelRececaoID
            // 
            this.labelRececaoID.AutoSize = true;
            this.labelRececaoID.Location = new System.Drawing.Point(63, 141);
            this.labelRececaoID.Name = "labelRececaoID";
            this.labelRececaoID.Size = new System.Drawing.Size(62, 13);
            this.labelRececaoID.TabIndex = 5;
            this.labelRececaoID.Text = "ReceçãoID";
            this.labelRececaoID.Visible = false;
            // 
            // buttonReservar
            // 
            this.buttonReservar.Location = new System.Drawing.Point(184, 229);
            this.buttonReservar.Name = "buttonReservar";
            this.buttonReservar.Size = new System.Drawing.Size(75, 23);
            this.buttonReservar.TabIndex = 4;
            this.buttonReservar.Text = "Reservar";
            this.buttonReservar.UseVisualStyleBackColor = true;
            this.buttonReservar.Visible = false;
            this.buttonReservar.Click += new System.EventHandler(this.buttonReservar_Click);
            // 
            // textServicoID
            // 
            this.textServicoID.Location = new System.Drawing.Point(148, 93);
            this.textServicoID.Name = "textServicoID";
            this.textServicoID.Size = new System.Drawing.Size(100, 20);
            this.textServicoID.TabIndex = 3;
            this.textServicoID.Visible = false;
            // 
            // labelServicoID
            // 
            this.labelServicoID.AutoSize = true;
            this.labelServicoID.Location = new System.Drawing.Point(63, 93);
            this.labelServicoID.Name = "labelServicoID";
            this.labelServicoID.Size = new System.Drawing.Size(54, 13);
            this.labelServicoID.TabIndex = 2;
            this.labelServicoID.Text = "ServiçoID";
            this.labelServicoID.Visible = false;
            // 
            // labelClienteID
            // 
            this.labelClienteID.AutoSize = true;
            this.labelClienteID.Location = new System.Drawing.Point(63, 47);
            this.labelClienteID.Name = "labelClienteID";
            this.labelClienteID.Size = new System.Drawing.Size(50, 13);
            this.labelClienteID.TabIndex = 1;
            this.labelClienteID.Text = "ClienteID";
            this.labelClienteID.Visible = false;
            // 
            // textClienteID
            // 
            this.textClienteID.Location = new System.Drawing.Point(148, 44);
            this.textClienteID.Name = "textClienteID";
            this.textClienteID.Size = new System.Drawing.Size(100, 20);
            this.textClienteID.TabIndex = 0;
            this.textClienteID.Visible = false;
            // 
            // listBoxIDClientes
            // 
            this.listBoxIDClientes.FormattingEnabled = true;
            this.listBoxIDClientes.Location = new System.Drawing.Point(40, 47);
            this.listBoxIDClientes.Name = "listBoxIDClientes";
            this.listBoxIDClientes.Size = new System.Drawing.Size(102, 251);
            this.listBoxIDClientes.TabIndex = 7;
            this.listBoxIDClientes.Visible = false;
            // 
            // listBoxNomeClientes
            // 
            this.listBoxNomeClientes.FormattingEnabled = true;
            this.listBoxNomeClientes.Location = new System.Drawing.Point(140, 47);
            this.listBoxNomeClientes.Name = "listBoxNomeClientes";
            this.listBoxNomeClientes.Size = new System.Drawing.Size(135, 251);
            this.listBoxNomeClientes.TabIndex = 9;
            this.listBoxNomeClientes.Visible = false;
            // 
            // listBoxNascClientes
            // 
            this.listBoxNascClientes.FormattingEnabled = true;
            this.listBoxNascClientes.Location = new System.Drawing.Point(274, 47);
            this.listBoxNascClientes.Name = "listBoxNascClientes";
            this.listBoxNascClientes.Size = new System.Drawing.Size(103, 251);
            this.listBoxNascClientes.TabIndex = 10;
            this.listBoxNascClientes.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.window);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "txtID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.window.ResumeLayout(false);
            this.window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button buttonServiços;
        private System.Windows.Forms.Button buttonVinicultura;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonReservas;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label CurrentWindow;
        private System.Windows.Forms.Panel window;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonReservar;
        private System.Windows.Forms.TextBox textServicoID;
        private System.Windows.Forms.Label labelServicoID;
        private System.Windows.Forms.Label labelClienteID;
        private System.Windows.Forms.TextBox textClienteID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textRececaoID;
        private System.Windows.Forms.Label labelRececaoID;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.ListBox listBoxIDClientes;
        private System.Windows.Forms.Button buttonFILL;
        private System.Windows.Forms.ListBox listBoxNomeClientes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBoxNascClientes;
        private System.Windows.Forms.ListBox listBoxCCClientes;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label label1;
    }
}

