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
using System.Text.RegularExpressions;
using System.Configuration;

namespace MADProyectoEneJun2023
{
    public partial class Reporteventas : Form
    {
        private string correo;
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

       

        public Reporteventas(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuAdmin
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correo);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }


        private string ObtenerFiltroPais()
        {
            if (rbtn_paisventas.Checked)
            {
                return txtbx_filtroventas.Text;
            }
            return null;
        }

        private string ObtenerFiltroCiudad()
        {
            if (rbtn_ciudadvantas.Checked)
            {
                return txtbx_filtroventas.Text;
            }
            return null;
        }


        private string ObtenerFiltroNombreHotel()
        {
            if (rbtn_hotelventas.Checked)
            {
                return txtbx_filtroventas.Text;
            }
            return null;
        }


        private void rbtn_paisventas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_paisventas.Checked)
            {
                string paisVentas = txtbx_filtroventas.Text;
                int filtroAno;

                if (int.TryParse(txtbx_fitroanoventas.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroVentasPais", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaisVentas", paisVentas);
                        command.Parameters.AddWithValue("@AnoVentasPais", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reporteventas.DataSource = dataTable;

                    }
                    conexion.Close();

                }
            }


            //if (!string.IsNullOrEmpty(txtbx_filtroventas.Text))
            //{
            //    conexion.Open();

            //    using (SqlCommand command = new SqlCommand("GetFiltroVentasPais", conexion))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.Parameters.AddWithValue("@PaisVentas", txtbx_filtroventas.Text);

            //        SqlDataAdapter adapter = new SqlDataAdapter(command);
            //        DataTable dataTable = new DataTable();
            //        adapter.Fill(dataTable);

            //        dgv_reporteventas.DataSource = dataTable;
            //    }

            //    conexion.Close();
            //}
        }

        private void rbtn_ciudadvantas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ciudadvantas.Checked)
            {
                string ciudadHotel = txtbx_filtroventas.Text;
                int filtroAno;
                if (int.TryParse(txtbx_fitroanoventas.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroVentasCiudad", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CiudadVentas", ciudadHotel);
                        command.Parameters.AddWithValue("@AnoVentasCiudad", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reporteventas.DataSource = dataTable;
                    }

                    conexion.Close();
                }
            }

        }

        private void rbtn_hotelventas_CheckedChanged(object sender, EventArgs e)
        {


            if (rbtn_hotelventas.Checked)
            {
                string nombreHotel = txtbx_filtroventas.Text;
                int filtroAno;

                if (int.TryParse(txtbx_fitroanoventas.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroVentasNombre", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreVentas", nombreHotel);
                        command.Parameters.AddWithValue("@AnoVentasNombre", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reporteventas.DataSource = dataTable;
                    }

                    conexion.Close();
                }
            }

        }

        private void btn_fitroanoventas_Click(object sender, EventArgs e)
        {
           

            if (int.TryParse(txtbx_fitroanoventas.Text, out int filtroAno))
            {
                //if (!string.IsNullOrEmpty(txtbx_fitroanoventas.Text))
                //{
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroVentasAno", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AnoVentas", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reporteventas.DataSource = dataTable;
                    }

                    conexion.Close();
                //}
            }
        }

        private void Reporteventas_Load(object sender, EventArgs e)
        {
            string consulta = "ObtenerDatosVentas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_reporteventas.DataSource = dt;
        }

        private void dgv_reporteventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "ObtenerDatosVentas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_reporteventas.DataSource = dt;
        }
    }
}
