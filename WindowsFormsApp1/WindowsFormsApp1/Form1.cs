﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public enum Create
        {
            Reserva,
            Cliente,
            Staff
        }
        public static Create create;

        public enum Change
        {
            Reserva,
            Cliente,
            Staff
        }
        public static Change change;

        public static int reservaSelecionada;
        public static string reserva;
        //cliente
        public static int clienteID;
        public static string clienteNome;
        public static string clienteNasc;
        public static int clienteCC;
        //staff
        public static int staffSelecionado;
        public static string staffNome;
        public static string staffHoraE;
        public static string staffHoraS;

        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viniculturaDataSet.Vindima' table. You can move, or remove it, as needed.
            this.vindimaTableAdapter.Fill(this.viniculturaDataSet.Vindima);
            // TODO: This line of code loads data into the 'viniculturaDataSet2.Vinho' table. You can move, or remove it, as needed.
            this.vinhoTableAdapter.Fill(this.viniculturaDataSet2.Vinho);
            // TODO: This line of code loads data into the 'viniculturaDataSet.Trabalhador' table. You can move, or remove it, as needed.
            this.trabalhadorTableAdapter.Fill(this.viniculturaDataSet.Trabalhador);
            // TODO: This line of code loads data into the 'viniculturaDataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.viniculturaDataSet.Reserva);
            // TODO: This line of code loads data into the 'viniculturaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.viniculturaDataSet.Cliente);
        }

        // ----------------------------------FUNÇOES UTILITARIAS -----------------------------------------------------
        public SqlConnection ConnectDataBase()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }

        void HideAll()
        {
            dgvReservas.Visible = false;
            dgvClientes.Visible = false;
            dgvStaff.Visible = false;
            btnAlterarReserva.Visible = false;
            btnEliminarReserva.Visible = false;
            btnCriarReserva.Visible = false;
            btnAlterarCliente.Visible = false;
            btnEliminarCliente.Visible = false;
            btnCriarCliente.Visible = false;
            btnAlterarStaff.Visible = false;
            btnEliminarStaff.Visible = false;
            btnCriarStaff.Visible = false;
            dgvVinhos.Visible = false;
            btnCriarVinho.Visible = false;
            btnQuery.Visible = false;
        }

        void FillDataBase()
        {
            SqlConnection con = ConnectDataBase();
            String query = "insert into Cliente(NomeCliente, DataNascimento, CartaoCidadao) values('Carlos Costa', 09 - 04 - 1985, 602754583)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted!");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //-----------------------------------FUNÇOES DATABASE---------------------------------------------------------

        #region RESERVAS

        private void btnReservas_Click(object sender, EventArgs e)
        {
            HideAll();
            dgvReservas.Visible = true;
            btnAlterarReserva.Visible = true;
            btnEliminarReserva.Visible = true;
            btnCriarReserva.Visible = true;

            SqlConnection con = ConnectDataBase();
            string query = "Select * from Reserva";

            var dataAdapter = new SqlDataAdapter(query, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvReservas.ReadOnly = true;
            dgvReservas.DataSource = ds.Tables[0];

        }

        private void btnCriarReserva_Click(object sender, EventArgs e)
        {
            create = Create.Reserva;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (f3.Visible == false)
            {
                dgvReservas.Update();
            }
        }

        private void btnAlterarReserva_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvReservas.CurrentCell.RowIndex;
            reservaSelecionada = int.Parse(dgvReservas.Rows[RowIndex].Cells[0].FormattedValue.ToString());

            change = Change.Reserva;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.Visible == false)
            {
                dgvReservas.Update();
            }
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvReservas.CurrentCell.RowIndex;
            int selected = int.Parse(dgvReservas.Rows[RowIndex].Cells[0].FormattedValue.ToString());

            SqlConnection con = ConnectDataBase();
            String query = "delete from Reserva where Reserva.ReservaID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reserva Eliminada!");
        }
        #endregion

        #region CLIENTES

        private void btnClientes_Click(object sender, EventArgs e)
        {
            HideAll();
            dgvClientes.Visible = true;
            btnAlterarCliente.Visible = true;
            btnEliminarCliente.Visible = true;
            btnCriarCliente.Visible = true;

            SqlConnection con = ConnectDataBase();
            string query = "Select * from Cliente";

            var dataAdapter = new SqlDataAdapter(query, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvClientes.ReadOnly = true;
            dgvClientes.DataSource = ds.Tables[0];
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            create = Create.Cliente;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (f3.Visible == false)
            {
                dgvClientes.Update();
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            //if (dgvClientes.SelectedCells.Count > 0)
            int RowIndex = dgvClientes.CurrentCell.RowIndex;
            clienteID = int.Parse(dgvClientes.Rows[RowIndex].Cells[0].FormattedValue.ToString());
            clienteNome = dgvClientes.Rows[RowIndex].Cells[1].FormattedValue.ToString();
            clienteNasc = dgvClientes.Rows[RowIndex].Cells[2].FormattedValue.ToString();
            clienteCC = int.Parse(dgvClientes.Rows[RowIndex].Cells[3].FormattedValue.ToString());

            change = Change.Cliente;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.Visible == false)
            {
                dgvClientes.Update();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvClientes.CurrentCell.RowIndex;
            int selected = int.Parse(dgvClientes.Rows[RowIndex].Cells[0].FormattedValue.ToString());

            SqlConnection con = ConnectDataBase();
            String query = "delete from cliente where cliente.ClienteID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Eliminado!");
        }

        #endregion

        #region STAFF

        private void btnStaff_Click(object sender, EventArgs e)
        {
            HideAll();
            btnAlterarStaff.Visible = true;
            btnEliminarStaff.Visible = true;
            dgvStaff.Visible = true;
            btnCriarStaff.Visible = true;

            SqlConnection con = ConnectDataBase();
            string query = "Select * from Trabalhador";

            var dataAdapter = new SqlDataAdapter(query, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvStaff.ReadOnly = true;
            dgvStaff.DataSource = ds.Tables[0];
        }

        private void btnCriarStaff_Click(object sender, EventArgs e)
        {
            create = Create.Staff;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            if (f3.Visible == false)
            {
                dgvStaff.Update();
            }
        }

        private void btnAlterarStaff_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvStaff.CurrentCell.RowIndex;
            staffSelecionado = int.Parse(dgvStaff.Rows[RowIndex].Cells[0].FormattedValue.ToString());
            staffNome = dgvStaff.Rows[RowIndex].Cells[1].FormattedValue.ToString();
            staffHoraE = dgvStaff.Rows[RowIndex].Cells[2].FormattedValue.ToString();
            staffHoraS = dgvStaff.Rows[RowIndex].Cells[3].FormattedValue.ToString();
            change = Change.Staff;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (f2.Visible == false)
            {
                dgvStaff.Update();
            }
        }


        private void btnEliminarStaff_Click(object sender, EventArgs e)
        {
            int RowIndex = dgvClientes.CurrentCell.RowIndex;
            int selected = int.Parse(dgvClientes.Rows[RowIndex].Cells[0].FormattedValue.ToString());

            SqlConnection con = ConnectDataBase();
            String query = "delete from Trabalhador where Trabalhador.TrabalhadorID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Trabalhador Eliminado!");
        }

        #endregion

        #region VINHOS

        private void btnVinhos_Click(object sender, EventArgs e)
        {
            HideAll();
            dgvVinhos.Visible = true;
            btnCriarVinho.Visible = true;

            int RowIndex = dgvStaff.CurrentCell.RowIndex;
            int VinhoID = int.Parse(dgvStaff.Rows[RowIndex].Cells[0].FormattedValue.ToString());

            if ( VinhoID != -1)
            {
                dgvVindima.Visible = true;

                SqlConnection con = ConnectDataBase();
                string query = "Select * from Vindima  join Plantacao on Plantacao.VindimaID = Vindima.VindimaID join Plantacao_ProducaoVinho on Plantacao.PlantacaoID = Plantacao_ProducaoVinho.PlantacaoID join ProducaoVinho on Plantacao_ProducaoVinho.ProducaoVinhoID = ProducaoVinho.ProducaoVinhoID join vinho on Vinho.ProducaoVinhoID = ProducaoVinho.ProducaoVinhoID where Vinho.VinhoID = " + VinhoID + "; "; 

                var dataAdapter = new SqlDataAdapter(query, con);
                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgvVindima.ReadOnly = true;
                dgvVindima.DataSource = ds.Tables[0];
            }
        }

        #endregion

        private void buttonFILL_Click(object sender, EventArgs e)
        {
            FillDataBase();
        }

        private void btnCriarVinho_Click(object sender, EventArgs e)
        {
            /* SqlConnection con = ConnectDataBase();
 SqlCommand cmd = new SqlCommand("Create_Vinho", con);
 cmd.CommandType = System.Data.CommandType.StoredProcedure;
 cmd.Parameters.AddWithValue("@XmlStr", XmlStrVariable);
 cmd.ExecuteNonQuery();*/
        }
    }
}
