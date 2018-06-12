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
    public partial class Form3 : Form
    {
        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(Form1.Create. == Form1.Create.Reserva)
        }

        //----------------------------------------

        public SqlConnection ConnectDataBase()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            int clienteID = int.Parse(Form1.selected);

            SqlConnection con = ConnectDataBase();
            String query = "Select * from Cliente where ClienteID = " + clienteID + ";";

            /*int userval = int.Parse(textClienteID.Text);
            int userval1 = int.Parse(textServicoID.Text);
            int userval2 = int.Parse(textRececaoID.Text);
            String query = "insert into Reserva (Cliente.clienteID, Servico.ServicoID, RececaoRecepID) values (" + userval + "," + userval1 + "," + userval2 + ");";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succecss!"); */
        }


        /*int userval = int.Parse(textClienteID.Text);
            int userval1 = int.Parse(textServicoID.Text);
            int userval2 = int.Parse(textRececaoID.Text);
            String query = "insert into Reserva (Cliente.clienteID, Servico.ServicoID, RececaoRecepID) values (" + userval + "," + userval1 + "," + userval2 + ");";
            */
    }
}
