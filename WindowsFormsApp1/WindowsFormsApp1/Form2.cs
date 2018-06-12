using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            int clienteID = int.Parse(Form1.selected);

            SqlConnection con = ConnectDataBase();
            String query = "Select * from Cliente where ClienteID = " + clienteID + ";";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    labelClienteID.Text = clienteID.ToString();

                    textBoxNome.Text = reader.GetString(reader.GetOrdinal("NomeCliente"));
                    textBoxNome.AppendText(reader["CartaoCidadao"].ToString());
                    //dateTimeData.Text = reader["DataNascimento"].ToString();
                    textBoxCartaoCidadao.Text = reader["CartaoCidado"].ToString();
                }
            }
        }

        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        public SqlConnection ConnectDataBase()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }

        private void buttonEliminarE_Click(object sender, EventArgs e)
        {
            int userval = int.Parse(Form1.selected);
            int userval1 = int.Parse((textBoxCartaoCidadao.Text).ToString());
            int userval2 = int.Parse(textBoxNome.Text);
            int userval3 = int.Parse(dateTimeData.Text);

            SqlConnection con = ConnectDataBase();
            String query = "insert into Cliente (ClienteID, NomeCliente, DataNascimento, CartaoCidadao) values (" + userval + "," + userval2 + "," + dateTimeData + textBoxCartaoCidadao + ");";
            SqlCommand cmd2 = new SqlCommand(query, con);

            MessageBox.Show("Cliente Alterado!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
