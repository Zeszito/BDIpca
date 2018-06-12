using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        public enum Create
        {
            Reserva,
            Cliente,
            Staff
        }
        Create create;

        public enum Change
        {
            Reserva,
            Cliente,
            Staff
        }
        Change change;

        public static string selected;
        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectDataBase();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q= "Select * from cliente";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made  Successfuly..!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            dgvReservas.Visible = true;
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
            create = Create.Cliente;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            /*if (f2.Visible == false)
            {
                RefreshListClientes();
            }*/

            /*SqlConnection con = ConnectDataBase();
            int userval = int.Parse(textClienteID.Text);
            int userval1 = int.Parse(textServicoID.Text);
            int userval2 = int.Parse(textRececaoID.Text);
            String query = "insert into Reserva (Cliente.clienteID, Servico.ServicoID, RececaoRecepID) values (" + userval + "," + userval1 + "," + userval2 + ");";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succecss!");*/
        }

        private void btnAlterarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            int selected = dgvReservas.SelectedCells[0].RowIndex;

            SqlConnection con = ConnectDataBase();
            String query = "delete from Reserva where Reserva.ReservaID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            dgvReservas.Rows.RemoveAt(selected);
            MessageBox.Show("Reserva Eliminada!");
            dgvReservas.Update();
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
            string query = "Select * from cliente";

            var dataAdapter = new SqlDataAdapter(query, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvClientes.ReadOnly = true;
            dgvClientes.DataSource = ds.Tables[0];
        }


        private void btnCriarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int selected = dgvClientes.SelectedCells[0].RowIndex;

            SqlConnection con = ConnectDataBase();
            String query = "delete from cliente where cliente.ClienteID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            dgvClientes.Rows.RemoveAt(selected);
            MessageBox.Show("Cliente Eliminado!");
            dgvClientes.Update();
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
            dgvClientes.ReadOnly = true;
            dgvClientes.DataSource = ds.Tables[0];
        }

        private void btnCriarStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarStaff_Click(object sender, EventArgs e)
        {
            int selected = dgvStaff.SelectedCells[0].RowIndex;

            SqlConnection con = ConnectDataBase();
            String query = "delete from Trabalhador where Trabalhador.TrabalhadorID = " + selected + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            dgvStaff.Rows.RemoveAt(selected);
            MessageBox.Show("Trabalhador Eliminado!");
            dgvStaff.Update();
        }

        #endregion

        #region SERVIÇOS

        private void btnServiços_Click(object sender, EventArgs e)
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
            dgvClientes.ReadOnly = true;
            dgvClientes.DataSource = ds.Tables[0];
        }
        #endregion


        private void buttonFILL_Click(object sender, EventArgs e)
        {
            FillDataBase();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            /*selected = listBoxIDClientes.SelectedItem.ToString();
            selected1 = listBoxIDClientes.SelectedItem.ToString();
            selected2 = listBoxIDClientes.SelectedItem.ToString();
            selected3 = listBoxIDClientes.SelectedItem.ToString();*/

            Form2 f2 = new Form2();
            f2.ShowDialog();
            /*if (f2.Visible == false)
            {
                RefreshListClientes();
            }*/
        }
    }
}
