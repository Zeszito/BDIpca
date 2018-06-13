using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            if(Form1.create == Form1.Create.Reserva)
            {
                labelReserva.Visible = true;
                btnCriar.Visible = true;
                labelClienteID.Visible = true;
                labelServicoID.Visible = true;
                labelRececaoID.Visible = true;
                textBoxNomeStaff.Visible = true;
                textBoxServicoID.Visible = true;
                textBoxRececaoID.Visible = true;
            }
            if (Form1.create == Form1.Create.Cliente)
            {
                labelCliente.Visible = true;
                btnCriar.Visible = true;
                LabelNomeCliente.Visible = true;
                labelDataNascimento.Visible = true;
                labelCartaoCidadao.Visible = true;
                textBoxNome.Visible = true;
                dateTimeData.Visible = true;
                textBoxCartaoCidadao.Visible = true;
            }
            if (Form1.create == Form1.Create.Staff)
            {
                labelStaff.Visible = true;
                btnCriar.Visible = true;
                labelNomeStaff.Visible = true;
                labelHoraEStaff.Visible = true;
                labelHoraSStaff.Visible = true;
                textBoxNomeStaff.Visible = true;
                textBoxHoraE.Visible = true;
                textBoxHoraS.Visible = true;
            }
        }

        // ----------------------------------FUNÇOES UTILITARIAS -----------------------------------------------------

        public SqlConnection ConnectDataBase()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            return con;
        }

        //-----------------------------------FUNÇOES DATABASE---------------------------------------------------------
            
        private void btnCriar_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectDataBase();

            if(Form1.create == Form1.Create.Reserva)
            {
                int userval = int.Parse(textBoxClienteID.Text.ToString());
                int userval1 = int.Parse(textBoxServicoID.Text.ToString());
                int userval2 = int.Parse(textBoxRececaoID.Text.ToString());
                String query = "insert into Reserva (Cliente.clienteID, Servico.ServicoID, RececaoRecepID) values (" + userval + "," + userval1 + "," + userval2 + ");";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            if (Form1.create == Form1.Create.Cliente)
            {
                String nome = textBoxNome.Text.ToString();
                DateTime data = (dateTimeData.Value);

                data = DateTime.ParseExact(data.ToString(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                int CC = int.Parse(textBoxCartaoCidadao.Text.ToString());
                String query = "insert into Cliente(NomeCliente, DataNascimento, CartaoCidadao) values('" + nome + "', " + data + ", " + CC + ");";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            if (Form1.create == Form1.Create.Staff)
            {
                int userval = int.Parse(textBoxNomeStaff.Text.ToString());
                int userval1 = int.Parse(textBoxHoraE.Text.ToString());
                int userval2 = int.Parse(textBoxHoraS.Text.ToString());
                String query = "insert into Trabalhador(NomeTrabalhador, HoraEntrada, HoraSaida) values('" + userval + "', " + userval1 +","+ userval2 +");";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Succecss!");
        }
    }
}