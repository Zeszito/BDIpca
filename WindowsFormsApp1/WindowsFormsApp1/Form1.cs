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
        public static int clienteSelecionado;
        public static int staffSelecionado;
        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        public Form1()
        {
            InitializeComponent();
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
            clienteSelecionado = int.Parse(dgvClientes.Rows[RowIndex].Cells[0].FormattedValue.ToString());

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
