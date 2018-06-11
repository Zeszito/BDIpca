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

        public string selected;
        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void window_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void window_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void window_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            HideAll();
            textClienteID.Visible = true;
            textServicoID.Visible = true;
            labelServicoID.Visible = true;
            labelClienteID.Visible = true;
            buttonReservar.Visible = true;
            labelRececaoID.Visible = true;
            textRececaoID.Visible = true;

        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectDataBase();
            int userval = int.Parse(textClienteID.Text);
            int userval1 = int.Parse(textServicoID.Text);
            int userval2 = int.Parse(textRececaoID.Text);
            String query = "insert into Reserva (Cliente.clienteID, Servico.ServicoID, RececaoRecepID) values (" + userval + "," + userval1 + "," + userval2 + ");";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succecss!");
        }

        public SqlConnection ConnectDataBase()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }

        void HideAll()
        {
            textClienteID.Visible = false;
            textServicoID.Visible = false;
            labelServicoID.Visible = false;
            labelClienteID.Visible = false;
            buttonReservar.Visible = false;
            labelClientes.Visible = false;
            listBoxNomeClientes.Visible = false;
            listBoxNascClientes.Visible = false;
            listBoxIDClientes.Visible = false;
            listBoxCCClientes.Visible = false;
            labelRececaoID.Visible = false;
            textRececaoID.Visible = false;
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            HideAll();
            labelClientes.Visible = true;
            listBoxIDClientes.Visible = true;
            listBoxNomeClientes.Visible = true;
            listBoxNascClientes.Visible = true;
            listBoxCCClientes.Visible = true;

            SqlConnection con = ConnectDataBase();
            string query = "Select * from cliente";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxIDClientes.Items.Add(reader["ClienteID"]);
                        listBoxNomeClientes.Items.Add(reader["NomeCliente"]);
                        listBoxNascClientes.Items.Add(reader["DataNascimento"]);
                        listBoxCCClientes.Items.Add(reader["CartaoCidadao"]);
                    }
                }
            }
        }

        private void buttonFILL_Click(object sender, EventArgs e)
        {
            FillDataBase();
            RefreshListClientes();
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

        private void button2_Click(object sender, EventArgs e)
        {

            String selected = listBoxIDClientes.SelectedItem.ToString();

            SqlConnection con = ConnectDataBase();
            int userval = int.Parse(selected);
            String query = "delete from cliente where cliente.ClienteID = " + userval + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Eliminado!");
            RefreshListClientes();
        }


        void RefreshListClientes()
        {
            listBoxNascClientes.Items.Clear();
            listBoxIDClientes.Items.Clear();
            listBoxNomeClientes.Items.Clear();
            listBoxCCClientes.Items.Clear();


            SqlConnection con = ConnectDataBase();
            string query = "Select * from cliente";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listBoxIDClientes.Items.Add(reader["ClienteID"]);
                        listBoxNomeClientes.Items.Add(reader["NomeCliente"]);
                        listBoxNascClientes.Items.Add(reader["DataNascimento"]);
                        listBoxCCClientes.Items.Add(reader["CartaoCidadao"]);
                    }
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            selected = listBoxIDClientes.SelectedItem.ToString();
            f2.ShowDialog();
            if (f2.Visible == false)
            {
                RefreshListClientes();
            }
        }
    }

   
}
