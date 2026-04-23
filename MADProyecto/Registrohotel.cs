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
using System.Text.RegularExpressions;

namespace MADProyectoEneJun2023
{
    public partial class Form_Registrohotel : Form
    {
        private string correoactual;
        private string nombrehotel;

        public Form_Registrohotel(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }
        //iniciar la conexion en que servidor la base de datos 
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);


        private void Form_Registrohotel_Load(object sender, EventArgs e)
        {
            //string consulta = "select * from Hotel";
            //string consulta = "select ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, " +
            //    "Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_Habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel, " +
            //    "Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel from Hotel";
            string consulta = "CargarHotel2";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_hotel.DataSource = dt;
        }

        public void llenar_tabla()
        {
            //string consulta = "select * from Hotel";
            //string consulta = "select ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, " +
            //    "Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_Habitaciones_hotel, Amenidades_hotel, Zona_turística_hotel, " +
            //    "Servicio_adicional_hotel, Sala_de_eventos_hotel, Fecha_inicio_operaciones_hotel, Teléfono_hotel from Hotel";
            string consulta = "CargarHotel2";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_hotel.DataSource = dt;
        }
        public bool Datosvacios()
        {
            if ( string.IsNullOrEmpty(txtbx_telhotel.Text) || string.IsNullOrEmpty(txtbx_seventoshotel.Text) ||
            string.IsNullOrEmpty(txtbx_sadicionalhotel.Text) || string.IsNullOrEmpty(txtbx_zturisticahotel.Text) || string.IsNullOrEmpty(txtbx_npisoshotel.Text) ||
            string.IsNullOrEmpty(txtbx_amenidadeshotel.Text) || string.IsNullOrEmpty(txtbx_nhabitacioneshotel.Text) || string.IsNullOrEmpty(txtbx_paishotel.Text) ||
            string.IsNullOrEmpty(txtbx_estadohotel.Text) || string.IsNullOrEmpty(txtbx_ciudadhotel.Text) || string.IsNullOrEmpty(txtbx_codigopostalhotel.Text) ||
            string.IsNullOrEmpty(txtbx_municipiohotel.Text) || string.IsNullOrEmpty(txtbx_nombrecallehotel.Text) ||
            string.IsNullOrEmpty(txtbx_nombrehotel.Text) )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void limpiar_campos()
        {
            txtbx_nombrehotel.Clear();
            txtbx_nombrecallehotel.Clear();
            txtbx_municipiohotel.Clear();
            txtbx_codigopostalhotel.Clear();
            txtbx_ciudadhotel.Clear();
            txtbx_estadohotel.Clear();
            txtbx_paishotel.Clear();
            txtbx_npisoshotel.Clear();
            txtbx_nhabitacioneshotel.Clear();
            txtbx_amenidadeshotel.Clear();
            txtbx_zturisticahotel.Clear();
            txtbx_sadicionalhotel.Clear();
            txtbx_seventoshotel.Clear();
            dttm_fechainiciooperaciones.Value=DateTimePicker.MinimumDateTime;
            txtbx_telhotel.Clear();
            txtbx_idhotel.Clear();
        }

        public bool Datosnum()
        {
            //7 digitos antes del punto, dos digitos después del cero. No quieres limites, {1, } no pongas número y será ilimitado
            if (Regex.IsMatch(txtbx_codigopostalhotel.Text, @"^[0-9]+$"))//Esto es para que sean números, cambiar las expresiones
            {
                if (Regex.IsMatch(txtbx_npisoshotel.Text, @"^[0-9]+$"))
                {
                    if (Regex.IsMatch(txtbx_nhabitacioneshotel.Text, @"^[0-9]+$"))
                    {
                        if (Regex.IsMatch(txtbx_telhotel.Text, @"^[0-9]+$"))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Teléfono de hotel no es un número");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Número de habitaciones no es un número");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Número de pisos no es un número valido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Código Postal no es un número");
                return false;
            }

        }

        private void btn_registrarhotel_Click(object sender, EventArgs e)
        {
            
            if (Datosvacios())
            {
                if (Datosnum())
                {
                    conexion.Open();
                    string consulta = "InsertarHotel";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@AdminHotel", correoactual);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", txtbx_nombrehotel.Text);
                    comando.Parameters.AddWithValue("@Calle", txtbx_nombrecallehotel.Text);
                    comando.Parameters.AddWithValue("@Municipio", txtbx_municipiohotel.Text);
                    comando.Parameters.AddWithValue("@CodigoPostal", txtbx_codigopostalhotel.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txtbx_ciudadhotel.Text);
                    comando.Parameters.AddWithValue("@Estado", txtbx_estadohotel.Text);
                    comando.Parameters.AddWithValue("@Pais", txtbx_paishotel.Text);
                    comando.Parameters.AddWithValue("@NumPisos", txtbx_npisoshotel.Text);
                    comando.Parameters.AddWithValue("@NumHabitaciones", txtbx_nhabitacioneshotel.Text);
                    comando.Parameters.AddWithValue("@Amenidades", txtbx_amenidadeshotel.Text);
                    comando.Parameters.AddWithValue("@ZonaTuristica", txtbx_zturisticahotel.Text);
                    comando.Parameters.AddWithValue("@ServicioAdicional", txtbx_sadicionalhotel.Text);
                    comando.Parameters.AddWithValue("@SalaEventos", txtbx_seventoshotel.Text);
                    comando.Parameters.AddWithValue("@FechaInicio", dttm_fechainiciooperaciones.Value);
                    comando.Parameters.AddWithValue("@Telefono", txtbx_telhotel.Text);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado");

                    llenar_tabla();
                    limpiar_campos();
                    conexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos, por favor");
            }
        }

        private void btn_eliminarhotel_Click(object sender, EventArgs e)
        {
            conexion.Open();
            int idHotel = int.Parse(txtbx_idhotel.Text);
            //string consulta = "DELETE FROM Hotel WHERE ID_hotel = @IDHotel AND ID_admin_hotel = 1";
            string consulta = "EliminarHotel";
            
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Hotel", idHotel);

            int filasAfectadas = comando.ExecuteNonQuery();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Registro eliminado");
                llenar_tabla();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("No se encontró el hotel con el ID especificado o el ID_admin_hotel no es igual a 1");
            }
    
            conexion.Close();
        }

        private void btn_editarhotel_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (Datosvacios())
            {
                if (Datosnum())
                {

                if (!string.IsNullOrEmpty(nombrehotel))
                {

                    string consulta = "ActualizarHotel";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Hotel", nombrehotel);
                    comando.Parameters.AddWithValue("@AdminHotel", correoactual);

                    comando.Parameters.AddWithValue("@Nombre", txtbx_nombrehotel.Text);
                    comando.Parameters.AddWithValue("@Calle", txtbx_nombrecallehotel.Text);
                    comando.Parameters.AddWithValue("@Municipio", txtbx_municipiohotel.Text);
                    comando.Parameters.AddWithValue("@CodigoPostal", txtbx_codigopostalhotel.Text);
                    comando.Parameters.AddWithValue("@Ciudad", txtbx_ciudadhotel.Text);
                    comando.Parameters.AddWithValue("@Estado", txtbx_estadohotel.Text);
                    comando.Parameters.AddWithValue("@Pais", txtbx_paishotel.Text);
                    comando.Parameters.AddWithValue("@NumPisos", txtbx_npisoshotel.Text);
                    comando.Parameters.AddWithValue("@NumHabitaciones", txtbx_nhabitacioneshotel.Text);
                    comando.Parameters.AddWithValue("@Amenidades", txtbx_amenidadeshotel.Text);
                    comando.Parameters.AddWithValue("@ZonaTuristica", txtbx_zturisticahotel.Text);
                    comando.Parameters.AddWithValue("@ServicioAdicional", txtbx_sadicionalhotel.Text);
                    comando.Parameters.AddWithValue("@SalaEventos", txtbx_seventoshotel.Text);
                    comando.Parameters.AddWithValue("@FechaInicio", dttm_fechainiciooperaciones.Value);
                    comando.Parameters.AddWithValue("@Telefono", txtbx_telhotel.Text);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro modificado");
                        llenar_tabla();
                        limpiar_campos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el hotel con el ID especificado");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un hotel para editar, asegurese de elegir el nombre");
                }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos, por favor");
            }
            

            conexion.Close();
        }

        private void dgv_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_hotel.Rows.Count)
            { 
             string hotel = Convert.ToString(dgv_hotel.Rows[e.RowIndex].Cells["Nombre_hotel"].Value);
            nombrehotel = hotel;
                MessageBox.Show(nombrehotel +" seleccionado");
                txtbx_idhotel.Text = nombrehotel;
            }
               
        }

        private void dgv_hotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_nombrehotel.Text = dgv_hotel.SelectedCells[2].Value.ToString();
            txtbx_nombrecallehotel.Text = dgv_hotel.SelectedCells[3].Value.ToString();
            txtbx_municipiohotel.Text = dgv_hotel.SelectedCells[4].Value.ToString();
            txtbx_codigopostalhotel.Text = dgv_hotel.SelectedCells[5].Value.ToString();
            txtbx_ciudadhotel.Text = dgv_hotel.SelectedCells[6].Value.ToString();
            txtbx_estadohotel.Text = dgv_hotel.SelectedCells[7].Value.ToString();
            txtbx_paishotel.Text = dgv_hotel.SelectedCells[8].Value.ToString();
            txtbx_npisoshotel.Text = dgv_hotel.SelectedCells[9].Value.ToString();
            txtbx_nhabitacioneshotel.Text = dgv_hotel.SelectedCells[10].Value.ToString();
            txtbx_amenidadeshotel.Text = dgv_hotel.SelectedCells[11].Value.ToString();
            txtbx_zturisticahotel.Text = dgv_hotel.SelectedCells[12].Value.ToString();
            txtbx_sadicionalhotel.Text = dgv_hotel.SelectedCells[13].Value.ToString();
            txtbx_seventoshotel.Text = dgv_hotel.SelectedCells[14].Value.ToString();
            dttm_fechainiciooperaciones.Text = dgv_hotel.SelectedCells[15].Value.ToString();
            txtbx_telhotel.Text = dgv_hotel.SelectedCells[16].Value.ToString();
            txtbx_idhotel.Text = dgv_hotel.SelectedCells[2].Value.ToString();//aquí está el que actualiza
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuAdmin
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correoactual);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }

        private void txtbx_idhotel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
