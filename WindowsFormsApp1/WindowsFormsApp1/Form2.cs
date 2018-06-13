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
        public string conString = "Data Source= TROLLSDUNGEON;Initial Catalog=Vinicultura;Integrated Security= True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.change == Form1.Change.Reserva)
            {
                labelReserva.Visible = true;
                btnAlterar.Visible = true;
                labelClienteID.Visible = true;
                labelServicoID.Visible = true;
                labelRececaoID.Visible = true;
                textBoxServicoID.Visible = true;
                textBoxRececaoID.Visible = true;

                int reservaID = Form1.reservaSelecionada;
                labelCliente.Text = "Informação da Reserva " + reservaID + "";
            }
            if (Form1.change == Form1.Change.Cliente)
            {
                labelCliente.Visible = true;
                btnAlterar.Visible = true;
                labelNomeCliente.Visible = true;
                labelDataNascimento.Visible = true;
                labelCartaoCidadao.Visible = true;
                textBoxNome.Visible = true;
                dateTimeData.Visible = true;
                textBoxCartaoCidadao.Visible = true;

                int clienteID = Form1.clienteID;
                labelCliente.Text = "Informação do Cliente " + clienteID + "";
                textBoxNome.Text = Form1.clienteNome;
                //dateTimeData.Text = Form1.clienteNasc;
                textBoxCartaoCidadao.Text = Form1.clienteCC.ToString(); 
            }
            if (Form1.change == Form1.Change.Staff)
            {
                labelStaff.Visible = true;
                btnAlterar.Visible = true;
                labelNomeCliente.Visible = true;
                labelHoraEStaff.Visible = true;
                labelHoraSStaff.Visible = true;
                textBoxNome.Visible = true;
                textBoxHoraE.Visible = true;
                textBoxHoraS.Visible = true;

                int trabalhadorID = Form1.staffSelecionado;
                labelStaff.Text = "Informação do Trabalhador " + trabalhadorID + "";
                textBoxNome.Text = Form1.staffNome;
                textBoxHoraE.Text = Form1.staffHoraE;
                textBoxHoraS.Text = Form1.staffHoraS;

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectDataBase();

            if (Form1.change == Form1.Change.Reserva)
            {
                int reservaID = Form1.reservaSelecionada;

                String dateE = (dateTimeData.Value.ToString("dd/MM/yyyy"));
                String dateS = (dateTimeData.Value.ToString("dd/MM/yyyy"));
                int recepID = int.Parse(textBoxRececaoID.Text.ToString());
                String query = "Update Reserva set DataEntrada = " + dateE + ",  DataSaida = " + dateS + ", RececaoID = " + recepID + " where ReservaID = " + reservaID + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            if (Form1.change == Form1.Change.Cliente)
            {
                int clienteID = Form1.clienteID;

                String nome = textBoxNome.Text.ToString();
                String data = (dateTimeData.Value.ToString("dd/MM/yyyy"));
                int cc = int.Parse(textBoxCartaoCidadao.Text.ToString());
                String query = "Update Cliente set NomeCliente = '" + nome + "', DataNascimento = " + data + ", CartaoCidadao = " + cc + " where ClienteID = " + clienteID + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            if (Form1.change == Form1.Change.Staff)
            {
                int trabalhadorID = Form1.staffSelecionado;
                String nomeT = textBoxNome.Text.ToString();
                int horaE = int.Parse(textBoxHoraE.Text.ToString());
                int horaS = int.Parse(textBoxHoraS.Text.ToString());
                String query = "Update Trabalhador set NomeTrabalhador = '" + nomeT + "', HoraEntrada = " + horaE + ", HoraSaida = " + horaS + " where TrabalhadorID = " + trabalhadorID + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Alteração completa!");
        }
    }
}
