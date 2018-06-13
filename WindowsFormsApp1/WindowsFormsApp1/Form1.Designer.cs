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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnServiços = new System.Windows.Forms.Button();
            this.btnVinicultura = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.buttonFILL = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.CurrentWindow = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viniculturaDataSet = new WindowsFormsApp1.ViniculturaDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WindowsFormsApp1.ViniculturaDataSetTableAdapters.ClienteTableAdapter();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartaoCidadaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalhadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.ReservaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new WindowsFormsApp1.ViniculturaDataSetTableAdapters.ReservaTableAdapter();
            this.btnCriarReserva = new System.Windows.Forms.Button();
            this.btnAlterarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.trabalhadorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTrabalhadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trabalhadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhadorTableAdapter = new WindowsFormsApp1.ViniculturaDataSetTableAdapters.TrabalhadorTableAdapter();
            this.btnCriarStaff = new System.Windows.Forms.Button();
            this.btnAlterarStaff = new System.Windows.Forms.Button();
            this.btnEliminarStaff = new System.Windows.Forms.Button();
            this.viniculturaDataSet1 = new WindowsFormsApp1.ViniculturaDataSet();
            this.reservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viniculturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viniculturaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Gray;
            this.sidePanel.Controls.Add(this.btnServiços);
            this.sidePanel.Controls.Add(this.btnVinicultura);
            this.sidePanel.Controls.Add(this.btnStaff);
            this.sidePanel.Controls.Add(this.btnClientes);
            this.sidePanel.Controls.Add(this.btnReservas);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 450);
            this.sidePanel.TabIndex = 1;
            // 
            // btnServiços
            // 
            this.btnServiços.BackColor = System.Drawing.Color.Gray;
            this.btnServiços.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiços.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.Location = new System.Drawing.Point(0, 316);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(200, 65);
            this.btnServiços.TabIndex = 5;
            this.btnServiços.Text = "Serviços";
            this.btnServiços.UseVisualStyleBackColor = false;
            this.btnServiços.Click += new System.EventHandler(this.btnServiços_Click);
            // 
            // btnVinicultura
            // 
            this.btnVinicultura.BackColor = System.Drawing.Color.Gray;
            this.btnVinicultura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVinicultura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVinicultura.Location = new System.Drawing.Point(0, 251);
            this.btnVinicultura.Name = "btnVinicultura";
            this.btnVinicultura.Size = new System.Drawing.Size(200, 65);
            this.btnVinicultura.TabIndex = 4;
            this.btnVinicultura.Text = "Vinicultura";
            this.btnVinicultura.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Gray;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(0, 186);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(200, 65);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Gray;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(0, 121);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 65);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.Gray;
            this.btnReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(0, 56);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(200, 65);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
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
            this.headerPanel.Size = new System.Drawing.Size(655, 56);
            this.headerPanel.TabIndex = 2;
            // 
            // buttonFILL
            // 
            this.buttonFILL.Location = new System.Drawing.Point(356, 18);
            this.buttonFILL.Name = "buttonFILL";
            this.buttonFILL.Size = new System.Drawing.Size(102, 23);
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
            this.Minimize.Location = new System.Drawing.Point(589, 9);
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
            this.Exit.Location = new System.Drawing.Point(622, 9);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // viniculturaDataSet
            // 
            this.viniculturaDataSet.DataSetName = "ViniculturaDataSet";
            this.viniculturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.viniculturaDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(607, 356);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(138, 38);
            this.btnEliminarCliente.TabIndex = 15;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Visible = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(454, 356);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(138, 38);
            this.btnAlterarCliente.TabIndex = 14;
            this.btnAlterarCliente.Text = "Alterar Cliente";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Visible = false;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.Location = new System.Drawing.Point(302, 356);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(138, 38);
            this.btnCriarCliente.TabIndex = 13;
            this.btnCriarCliente.Text = "Adicionar Cliente";
            this.btnCriarCliente.UseVisualStyleBackColor = true;
            this.btnCriarCliente.Visible = false;
            this.btnCriarCliente.Click += new System.EventHandler(this.btnCriarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cartaoCidadaoDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.clienteBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(302, 84);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(443, 232);
            this.dgvClientes.TabIndex = 9;
            this.dgvClientes.Visible = false;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // cartaoCidadaoDataGridViewTextBoxColumn
            // 
            this.cartaoCidadaoDataGridViewTextBoxColumn.DataPropertyName = "CartaoCidadao";
            this.cartaoCidadaoDataGridViewTextBoxColumn.HeaderText = "CartaoCidadao";
            this.cartaoCidadaoDataGridViewTextBoxColumn.Name = "cartaoCidadaoDataGridViewTextBoxColumn";
            // 
            // trabalhadorBindingSource1
            // 
            this.trabalhadorBindingSource1.DataMember = "Trabalhador";
            this.trabalhadorBindingSource1.DataSource = this.viniculturaDataSet;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservaID,
            this.dataGridViewTextBoxColumn1,
            this.ServicoID,
            this.DataEntrada});
            this.dgvReservas.DataSource = this.reservaBindingSource;
            this.dgvReservas.Location = new System.Drawing.Point(302, 84);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(443, 232);
            this.dgvReservas.TabIndex = 16;
            this.dgvReservas.Visible = false;
            // 
            // ReservaID
            // 
            this.ReservaID.DataPropertyName = "ReservaID";
            this.ReservaID.HeaderText = "ReservaID";
            this.ReservaID.Name = "ReservaID";
            this.ReservaID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClienteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClienteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ServicoID
            // 
            this.ServicoID.DataPropertyName = "ServicoID";
            this.ServicoID.HeaderText = "ServicoID";
            this.ServicoID.Name = "ServicoID";
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.HeaderText = "DataEntrada";
            this.DataEntrada.Name = "DataEntrada";
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.viniculturaDataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // btnCriarReserva
            // 
            this.btnCriarReserva.Location = new System.Drawing.Point(302, 356);
            this.btnCriarReserva.Name = "btnCriarReserva";
            this.btnCriarReserva.Size = new System.Drawing.Size(138, 38);
            this.btnCriarReserva.TabIndex = 17;
            this.btnCriarReserva.Text = "Adicionar Reserva";
            this.btnCriarReserva.UseVisualStyleBackColor = true;
            this.btnCriarReserva.Visible = false;
            this.btnCriarReserva.Click += new System.EventHandler(this.btnCriarReserva_Click);
            // 
            // btnAlterarReserva
            // 
            this.btnAlterarReserva.Location = new System.Drawing.Point(454, 356);
            this.btnAlterarReserva.Name = "btnAlterarReserva";
            this.btnAlterarReserva.Size = new System.Drawing.Size(138, 38);
            this.btnAlterarReserva.TabIndex = 18;
            this.btnAlterarReserva.Text = "Alterar Reserva";
            this.btnAlterarReserva.UseVisualStyleBackColor = true;
            this.btnAlterarReserva.Visible = false;
            this.btnAlterarReserva.Click += new System.EventHandler(this.btnAlterarReserva_Click);
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Location = new System.Drawing.Point(607, 356);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(138, 38);
            this.btnEliminarReserva.TabIndex = 19;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            this.btnEliminarReserva.Visible = false;
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoGenerateColumns = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trabalhadorIDDataGridViewTextBoxColumn,
            this.nomeTrabalhadorDataGridViewTextBoxColumn,
            this.horaEntradaDataGridViewTextBoxColumn,
            this.horaSaidaDataGridViewTextBoxColumn});
            this.dgvStaff.DataSource = this.trabalhadorBindingSource;
            this.dgvStaff.Location = new System.Drawing.Point(302, 84);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(443, 232);
            this.dgvStaff.TabIndex = 20;
            this.dgvStaff.Visible = false;
            // 
            // trabalhadorIDDataGridViewTextBoxColumn
            // 
            this.trabalhadorIDDataGridViewTextBoxColumn.DataPropertyName = "TrabalhadorID";
            this.trabalhadorIDDataGridViewTextBoxColumn.HeaderText = "TrabalhadorID";
            this.trabalhadorIDDataGridViewTextBoxColumn.Name = "trabalhadorIDDataGridViewTextBoxColumn";
            this.trabalhadorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeTrabalhadorDataGridViewTextBoxColumn
            // 
            this.nomeTrabalhadorDataGridViewTextBoxColumn.DataPropertyName = "NomeTrabalhador";
            this.nomeTrabalhadorDataGridViewTextBoxColumn.HeaderText = "NomeTrabalhador";
            this.nomeTrabalhadorDataGridViewTextBoxColumn.Name = "nomeTrabalhadorDataGridViewTextBoxColumn";
            // 
            // horaEntradaDataGridViewTextBoxColumn
            // 
            this.horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.HeaderText = "HoraEntrada";
            this.horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            // 
            // horaSaidaDataGridViewTextBoxColumn
            // 
            this.horaSaidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSaida";
            this.horaSaidaDataGridViewTextBoxColumn.HeaderText = "HoraSaida";
            this.horaSaidaDataGridViewTextBoxColumn.Name = "horaSaidaDataGridViewTextBoxColumn";
            // 
            // trabalhadorBindingSource
            // 
            this.trabalhadorBindingSource.DataMember = "Trabalhador";
            this.trabalhadorBindingSource.DataSource = this.viniculturaDataSet;
            // 
            // trabalhadorTableAdapter
            // 
            this.trabalhadorTableAdapter.ClearBeforeFill = true;
            // 
            // btnCriarStaff
            // 
            this.btnCriarStaff.Location = new System.Drawing.Point(302, 356);
            this.btnCriarStaff.Name = "btnCriarStaff";
            this.btnCriarStaff.Size = new System.Drawing.Size(138, 38);
            this.btnCriarStaff.TabIndex = 21;
            this.btnCriarStaff.Text = "Adicionar Trabalhador";
            this.btnCriarStaff.UseVisualStyleBackColor = true;
            this.btnCriarStaff.Visible = false;
            this.btnCriarStaff.Click += new System.EventHandler(this.btnCriarStaff_Click);
            // 
            // btnAlterarStaff
            // 
            this.btnAlterarStaff.Location = new System.Drawing.Point(454, 356);
            this.btnAlterarStaff.Name = "btnAlterarStaff";
            this.btnAlterarStaff.Size = new System.Drawing.Size(138, 38);
            this.btnAlterarStaff.TabIndex = 22;
            this.btnAlterarStaff.Text = "Alterar Trabalhador";
            this.btnAlterarStaff.UseVisualStyleBackColor = true;
            this.btnAlterarStaff.Visible = false;
            this.btnAlterarStaff.Click += new System.EventHandler(this.btnAlterarStaff_Click);
            // 
            // btnEliminarStaff
            // 
            this.btnEliminarStaff.Location = new System.Drawing.Point(607, 356);
            this.btnEliminarStaff.Name = "btnEliminarStaff";
            this.btnEliminarStaff.Size = new System.Drawing.Size(138, 38);
            this.btnEliminarStaff.TabIndex = 23;
            this.btnEliminarStaff.Text = "Eliminar Trabalhador";
            this.btnEliminarStaff.UseVisualStyleBackColor = true;
            this.btnEliminarStaff.Visible = false;
            this.btnEliminarStaff.Click += new System.EventHandler(this.btnEliminarStaff_Click);
            // 
            // viniculturaDataSet1
            // 
            this.viniculturaDataSet1.DataSetName = "ViniculturaDataSet";
            this.viniculturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource1
            // 
            this.reservaBindingSource1.DataMember = "Reserva";
            this.reservaBindingSource1.DataSource = this.viniculturaDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.btnCriarCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnCriarReserva);
            this.Controls.Add(this.btnAlterarReserva);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnCriarStaff);
            this.Controls.Add(this.btnAlterarStaff);
            this.Controls.Add(this.btnEliminarStaff);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.dgvClientes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "txtID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viniculturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viniculturaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnServiços;
        private System.Windows.Forms.Button btnVinicultura;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label CurrentWindow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonFILL;
        private ViniculturaDataSet viniculturaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ViniculturaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnCriarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private ViniculturaDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.Button btnCriarReserva;
        private System.Windows.Forms.Button btnAlterarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.BindingSource trabalhadorBindingSource;
        private ViniculturaDataSetTableAdapters.TrabalhadorTableAdapter trabalhadorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabalhadorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTrabalhadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCriarStaff;
        private System.Windows.Forms.Button btnAlterarStaff;
        private System.Windows.Forms.Button btnEliminarStaff;
        private System.Windows.Forms.BindingSource trabalhadorBindingSource1;
        private ViniculturaDataSet viniculturaDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartaoCidadaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservaBindingSource1;
    }
}

