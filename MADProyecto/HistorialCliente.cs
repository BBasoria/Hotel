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
using MADProyectoEneJun2023.Resources;
using System.Configuration;

namespace MADProyectoEneJun2023
{
    public partial class HistorialCliente : Form
    {
        private string correo;
        public HistorialCliente(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }


        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);


        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuOperativo
            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correo);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
        }

        private void btn_filtraranocliente_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtn_apellidos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_filtraranocliente_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtbx_filtroanocliente.Text, out int filtroAno))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetFiltroHistorialClienteAno", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AnoOperacionesCliente", filtroAno);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_clientehistorial.DataSource = dataTable;
                }

                conexion.Close();
            }
        }

        private void txtbx_ap_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_apellidos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtn_apellidos.Checked) // Verifica si el RadioButton está seleccionado
            {

                if (int.TryParse(txtbx_filtroanocliente.Text, out int filtroAno))
                {
                    string apellidoP = txtbx_ap.Text;
                    string apellidoM = txtbx_am.Text;
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetClienteByApellidosCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PAP", apellidoP);
                        command.Parameters.AddWithValue("@MAP", apellidoM);
                        command.Parameters.AddWithValue("@AnoOperacionesCliente", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_clientehistorial.DataSource = dataTable;
                    }
                    conexion.Close();
                }
            }
        }

        private void rbtn_rfc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_rfc.Checked) // Verifica si el RadioButton está seleccionado
            {
                if (int.TryParse(txtbx_filtroanocliente.Text, out int filtroAno))
                {
                    string rfc = txtbx_filtrocliente.Text;
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetClienteByRFCCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Rfc", txtbx_filtrocliente.Text);
                        command.Parameters.AddWithValue("@AnoOperacionesCliente", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_clientehistorial.DataSource = dataTable;
                    }
                    conexion.Close();
                }
            }

        }

        private void rbtn_correo_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtn_correo.Checked) // Verifica si el RadioButton está seleccionado
            {
                if (int.TryParse(txtbx_filtroanocliente.Text, out int filtroAno))
                {
                    string correo = txtbx_filtrocliente.Text;
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetClienteByEmailCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Correo", txtbx_filtrocliente.Text);
                        command.Parameters.AddWithValue("@AnoOperacionesCliente", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_clientehistorial.DataSource = dataTable;
                    }
                    conexion.Close();
                }
            }
            
        }
    }
}
