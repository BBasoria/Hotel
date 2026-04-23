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
    public partial class Habitacion : Form
    {
        private string correo;
        private int HotelID;
        private int TipoID;
        private int IdHab;
        private int HotelHabID;
        public Habitacion(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }

        //iniciar la conexion en que servidor la base de datos 
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        public void llenar_tabla()
        {
            
            string consulta1 = "CargarTipoHabitacion";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);
            dgv_tipohabitacion.DataSource = dt1;

            
            string consulta3 = "CargarHabitacion";
            SqlDataAdapter adaptador3 = new SqlDataAdapter(consulta3, conexion);
            DataTable dt3 = new DataTable();
            adaptador3.Fill(dt3);
            dgv_habitacion.DataSource = dt3;
        }

        public void limpiar_campos()
        {
            txtbx_tiphhabitacion.Clear();
            txtbx_hhabitacion.Clear();
            txtbx_numhab.Clear();
        }

        private void Habitacion_Load(object sender, EventArgs e)
        {
            //consulta el tipo de habitacion

            //string consulta1 = "CargarTipoHabitacion";
            //SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            //DataTable dt1 = new DataTable();
            //adaptador1.Fill(dt1);
            //dgv_tipohabitacion.DataSource = dt1;

            //consulta la habitacion

            string consulta3 = "CargarHabitacion";
            SqlDataAdapter adaptador3 = new SqlDataAdapter(consulta3, conexion);
            DataTable dt3 = new DataTable();
            adaptador3.Fill(dt3);
            dgv_habitacion.DataSource = dt3;

            //consulta tipos de hoteles 
            string consulta = "CargarHotel2";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_hotel.DataSource = dt;

        }

        private void dgv_tipohabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_tipohabitacion.Rows.Count)
            {
                int IDTipo = Convert.ToInt32(dgv_tipohabitacion.Rows[e.RowIndex].Cells["Código_tipo_habitación"].Value);
                string NoombreTipo = Convert.ToString(dgv_tipohabitacion.Rows[e.RowIndex].Cells["Nivel_de_habitación_thabitación"].Value);
                TipoID = IDTipo;
                if(TipoID != 0)
                {
                    MessageBox.Show(NoombreTipo + " seleccionado");
                }
                else
                {
                    MessageBox.Show("Seleccione la celda de Tipo de Habitación, de nuevo.");
                }
                
            }
        }

        private void dgv_tipohabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_tiphhabitacion.Text = dgv_tipohabitacion.SelectedCells[0].Value.ToString();
            //consulta el hotel
          
            //string consulta2 = "CargarHotel";
            //SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion);
            //DataTable dt2 = new DataTable();
            //adaptador2.Fill(dt2);
            //dgv_hotel.DataSource = dt2;
        }

        private void dgv_hotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_hhabitacion.Text = dgv_hotel.SelectedCells[0].Value.ToString();
        }

        private void btn_registrarnumhab_Click(object sender, EventArgs e)
        {
            conexion.Close();
            conexion.Open();
            if(!string.IsNullOrEmpty(TipoID.ToString()) && !string.IsNullOrEmpty(HotelID.ToString()) && TipoID !=0 && HotelID !=0)
            {
            // Obtener la fecha y hora actual
            DateTime fechaHoraRegistro = DateTime.Now;

            // Insertar la nueva habitación en la tabla Habitación
     
            string consulta = "InsertarHabitacion";
            SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@HabitacionCreadaAdmin", correo); // ID_admin = 1
            comando.Parameters.AddWithValue("@TipoHabitacion", TipoID); // Obtener el código de tipo de habitación
            comando.Parameters.AddWithValue("@IDHotel", HotelID); // Obtener el ID del hotel
            comando.Parameters.AddWithValue("@FechaHoraRegistro", fechaHoraRegistro);

            comando.ExecuteNonQuery();
            MessageBox.Show("Registro agregado");
            llenar_tabla();
            limpiar_campos();
            }
            else
            {
                MessageBox.Show("Para registrar habitación, seleccione el Hotel y el Tipo de Habitación.");
            }
            
            conexion.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuAdmin
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correo);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }

        private void dgv_habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //consulta la habitacion
            
            string consulta3 = "CargarHabitacion";
            SqlDataAdapter adaptador3 = new SqlDataAdapter(consulta3, conexion);
            DataTable dt3 = new DataTable();
            adaptador3.Fill(dt3);
            dgv_habitacion.DataSource = dt3;

            /*
              if (e.RowIndex >= 0 && e.RowIndex < dgv_habitacion.Rows.Count)
            {
                int IDHab = Convert.ToInt32(dgv_habitacion.Rows[e.RowIndex].Cells["Número_habitación"].Value);
                IdHab = IDHab;
                if (IdHab !=0)
            */

            if (e.RowIndex >= 0 && e.RowIndex < dgv_habitacion.Rows.Count)
            {
                
            }

               


        }

        private void dgv_habitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.RowIndex < dgv_habitacion.Rows.Count)
            {
                int IDHab = Convert.ToInt32(dgv_habitacion.Rows[e.RowIndex].Cells["Número_habitación"].Value);

                IdHab = IDHab;
                if (IdHab !=0)
                {
                    MessageBox.Show(IdHab + " habitación seleccionada");

                    int HotelIDHab = Convert.ToInt32(dgv_habitacion.Rows[e.RowIndex].Cells["ID_hotel_habitación"].Value);
                    HotelHabID = HotelIDHab;
                    if (HotelHabID != 0)
                    {
                        conexion.Open();

                        using (SqlCommand command = new SqlCommand("CargarHotelconHabitación", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@IDHOTEL", HotelHabID);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_hotel.DataSource = dataTable;
                        }
                        conexion.Close();


                        conexion.Open();

                        using (SqlCommand command = new SqlCommand("CargarTipoHabitacionconHotel", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ID_Hotel", HotelHabID);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_tipohabitacion.DataSource = dataTable;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        MessageBox.Show("Para mostrar los datos de una habitación seleccione la celda en la tabla, de nuevo.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione la celda de Habitación, de nuevo.");
                }


            }
        }

        private void btn_editarnumhab_Click(object sender, EventArgs e)
        {
            conexion.Open();
            // Obtener la fecha y hora actual
            if (!string.IsNullOrEmpty(TipoID.ToString()) && !string.IsNullOrEmpty(HotelID.ToString()) && TipoID !=0 && HotelID !=0)
            {
                DateTime fechaHoraRegistro = DateTime.Now;

                string consulta = "ActualizarHabitacion";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@TipoHabitacion", TipoID); // Obtener el código de tipo de habitación
                comando.Parameters.AddWithValue("@IDHotel", HotelID); // Obtener el ID del hotel
                comando.Parameters.AddWithValue("@FechaHoraRegistro", fechaHoraRegistro);
                comando.Parameters.AddWithValue("@NumeroHabitacion", IdHab);

                int filasActualizadas = comando.ExecuteNonQuery();

                if (filasActualizadas > 0)
                {
                    MessageBox.Show("Habitación actualizada correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró la habitación con el número especificado");
                }
                llenar_tabla();
                limpiar_campos();
            }
            else
            {
                MessageBox.Show("Para editar habitación, seleccione el Hotel y el Tipo de Habitación que desee poner.");
            }
           
            conexion.Close();
        }

        private void btn_eliminarnumhab_Click(object sender, EventArgs e)
        {
            conexion.Open();
            // Obtener la fecha y hora actual
            DateTime fechaHoraRegistro = DateTime.Now;

            // Eliminar la habitación de la tabla Habitación
          
            string consulta = "EliminarHabitacion";
            
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@NumeroHabitacion", txtbx_numhab.Text);

            int filasEliminadas = comando.ExecuteNonQuery();

            if (filasEliminadas > 0)
            {
                MessageBox.Show("Habitación eliminada correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró la habitación con el número especificado");
            }
            llenar_tabla();
            limpiar_campos();
            conexion.Close();
        }

        private void dgv_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgv_hotel.Rows.Count)
            {
                // Get the selected hotel ID from the dgv_hotelreserv DataGridView
                int hotelID = Convert.ToInt32(dgv_hotel.Rows[e.RowIndex].Cells["ID_hotel"].Value);
                string hotelnombre = Convert.ToString(dgv_hotel.Rows[e.RowIndex].Cells["Nombre_hotel"].Value);
                HotelID = hotelID;

                if (HotelID != 0)
                {
                    MessageBox.Show(hotelnombre + " seleccionado");
                }
                else
                {
                    MessageBox.Show("Seleccione la celda de Hotel, de nuevo.");
                }

               

                conexion.Open();

                using (SqlCommand command = new SqlCommand("CargarTipoHabitacionconHotel", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Hotel", hotelID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_tipohabitacion.DataSource = dataTable;
                }
                conexion.Close();
            }


        }

        private void txtbx_hhabitacion_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void RefrescarHotel_Click(object sender, EventArgs e)
        {
            string consulta = "CargarHotel2";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_hotel.DataSource = dt;
        }
    }
}
