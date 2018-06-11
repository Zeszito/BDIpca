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

            Form1 f1 = new Form1();
            int clienteID = int.Parse(f1.selected);

            SqlConnection con = ConnectDataBase();
            int userval = int.Parse(textBoxID.Text);
            int userval1 = int.Parse(textBoxCartaoCidadao.Text);
            int userval2 = int.Parse(textBoxNome.Text);
            int userval3 = int.Parse(dateTimeData.Text);

            String query = "Select* from Cliente where Cliente.ClienteID = "+  + ";";

            textBoxID.Text = 

            "insert into Cliente (ClienteID, NomeCliente, DataNascimento, CartaoCidadao) values (" + userval + "," + userval2 + "," + dateTimeData + textBoxCartaoCidadao +");";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente Alterado!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
