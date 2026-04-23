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
    public partial class Reporteocupacion : Form
    {
        private string correo;
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        public Reporteocupacion(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }

        private void Reportehotel_Load(object sender, EventArgs e)
        {

            //string consulta1 = "select Nombre_hotel, Ciudad_hotel, Fecha_inicio_operaciones_hotel, Código_tipo_habitación, " +
            //"Cantidad_Habitaciones, Porcentaje_Ocupacion, Total_Personas_Hospedadas from vHotel1";
            string consulta1 = "ObtenerDatosHotel";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);
            dgv_reportehotel.DataSource = dt1;
            
            //string consulta2 = "select Nombre_hotel, Ciudad_hotel, Fecha_inicio_operaciones_hotel, " +
            //    "Porcentaje_Ocupacion from vHotel1";
            string consulta2 = "ObtenerDatosHotelResum";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion);
            DataTable dt2 = new DataTable();
            adaptador2.Fill(dt2);
            dgv_reportehotel2.DataSource = dt2;
            
            //string consulta3 = "select Nombre_hotel, Ciudad_hotel, Fecha_creación_reservación, Ingreso_Hospedaje, " +
            //    "Servicio_adicional_hotel from vVentas1";
            //string consulta3 = "ObtenerDatosVentas";
            //SqlDataAdapter adaptador3 = new SqlDataAdapter(consulta3, conexion);
            //DataTable dt3 = new DataTable();
            //adaptador3.Fill(dt3);
            //dgv_reporteventas.DataSource = dt3;

        }

        private string ObtenerFiltroPais()
        {
            if (rbtn_pais.Checked)
            {
                return txtbx_filtrohotel.Text;
            }
            return null;
        }

        private string ObtenerFiltroCiudad()
        {
            if (rbtn_ciudad.Checked)
            {
                return txtbx_filtrohotel.Text;
            }
            return null;
        }


        private string ObtenerFiltroNombreHotel()
        {
            if (rbtn_hotel.Checked)
            {
                return txtbx_filtrohotel.Text;
            }
            return null;
        }

        private void dgv_reportehotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void rbtn_pais_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_pais.Checked)
            {
                string paisHotel = txtbx_filtrohotel.Text;
                int filtroAno;

                if (int.TryParse(txtbx_fitroanohotel.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelPais1", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaisHotel", paisHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reportehotel.DataSource = dataTable;
                    }

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelPaisResum", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaisHotel", paisHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        DataTable dataTable2 = new DataTable();
                        adapter2.Fill(dataTable2);

                        dgv_reportehotel2.DataSource = dataTable2;
                    }

                    conexion.Close();
                }
            }

        }

        private void rbtn_ciudad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ciudad.Checked)
            {
                string ciudadHotel = txtbx_filtrohotel.Text;
                int filtroAno;

                if (int.TryParse(txtbx_fitroanohotel.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelCiudad1", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CiudadHotel", ciudadHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reportehotel.DataSource = dataTable;
                    }

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelCiudadResum", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CiudadHotel", ciudadHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        DataTable dataTable2 = new DataTable();
                        adapter2.Fill(dataTable2);

                        dgv_reportehotel2.DataSource = dataTable2;
                    }

                    conexion.Close();
                }
            }
       
        }

        private void rbtn_hotel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_hotel.Checked)
            {
                string nombreHotel = txtbx_filtrohotel.Text;
                int filtroAno;

                if (int.TryParse(txtbx_fitroanohotel.Text, out filtroAno))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelAnoNombre", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreHotel", nombreHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_reportehotel.DataSource = dataTable;
                    }

                    using (SqlCommand command = new SqlCommand("GetFiltroHotelNombreResum", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NombreHotel", nombreHotel);
                        command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        DataTable dataTable2 = new DataTable();
                        adapter2.Fill(dataTable2);

                        dgv_reportehotel2.DataSource = dataTable2;
                    }

                    conexion.Close();
                }
            }

        }


        private void rbtn_ano_CheckedChanged(object sender, EventArgs e)
        {
            //int? filtroAno = ObtenerFiltroAno();

            //if (!string.IsNullOrEmpty(txtbx_filtrohotel.Text))
            if (int.TryParse(txtbx_filtrohotel.Text, out int filtroAno))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetFiltroHotelAno1", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_reportehotel.DataSource = dataTable;
                }

                using (SqlCommand command = new SqlCommand("GetFiltroHotelAnoResum", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    DataTable dataTable2 = new DataTable();
                    adapter2.Fill(dataTable2);

                    dgv_reportehotel2.DataSource = dataTable2;
                }

        
                conexion.Close();
            }
        }

        private void rbtn_hotelventas_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void dgv_reporteventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuAdmin
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correo);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }

        private void rbtn_paisventas_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void rbtn_ciudadvantas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_anoventas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_filtrohotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_filtroanohotel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbx_fitroanohotel.Text, out int filtroAno))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetFiltroHotelAno1", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_reportehotel.DataSource = dataTable;
                }

                using (SqlCommand command = new SqlCommand("GetFiltroHotelAnoResum", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AnoOperacionesHotel", filtroAno);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                    DataTable dataTable2 = new DataTable();
                    adapter2.Fill(dataTable2);

                    dgv_reportehotel2.DataSource = dataTable2;
                }


                conexion.Close();
            }
        }

        private void btn_fitroanoventas_Click(object sender, EventArgs e)
        {
 
        }

        private void txtbx_fitroanoventas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_filtroventas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta1 = "ObtenerDatosHotel";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);
            dgv_reportehotel.DataSource = dt1;

            //string consulta2 = "select Nombre_hotel, Ciudad_hotel, Fecha_inicio_operaciones_hotel, " +
            //    "Porcentaje_Ocupacion from vHotel1";
            string consulta2 = "ObtenerDatosHotelResum";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion);
            DataTable dt2 = new DataTable();
            adaptador2.Fill(dt2);
            dgv_reportehotel2.DataSource = dt2;
        }
    }
}
