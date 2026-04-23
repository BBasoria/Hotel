using MADProyectoEneJun2023.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace MADProyectoEneJun2023
{
    public partial class From_Reservacion : Form
    {
        private string correoactual;
        private int clienteID;
        private int HotelID;
        private int HabitacionID;
        private int TipoID;
        public From_Reservacion(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void ckbx_correoreserv_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void limpiar_campos()
        {
            txtbx_dinerofaltantereserv.Clear();
            txtbx_anticiporeserv.Clear();
            txtbx_montototalreserv.Clear();
            cbbx_tipodepagoreserv.Text = string.Empty;
            txtbx_numpersonasreserv.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            txtbx_filtrosreserv.Clear();
            dttm_fechainicio.Value = DateTimePicker.MinimumDateTime;
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
        }
        public bool Datosvacios()
        {
            if (string.IsNullOrEmpty(clienteID.ToString()) || string.IsNullOrEmpty(HotelID.ToString()) || string.IsNullOrEmpty(HabitacionID.ToString()) || string.IsNullOrEmpty(txtbx_numpersonasreserv.Text) || string.IsNullOrEmpty(cbbx_tipodepagoreserv.Text) ||
                string.IsNullOrEmpty(txtbx_montototalreserv.Text) || string.IsNullOrEmpty(txtbx_anticiporeserv.Text) || string.IsNullOrEmpty(txtbx_dinerofaltantereserv.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Datosnum()
        {
            //7 digitos antes del punto, dos digitos después del cero. No quieres limites, {1, } no pongas número y será ilimitado
            if (Regex.IsMatch(txtbx_numpersonasreserv.Text, @"^[0-9]+$"))
            {
                if (Regex.IsMatch(txtbx_montototalreserv.Text, @"^(\d{1,7})(\.\d{1,2}){0,1}$"))
                {
                    if (Regex.IsMatch(txtbx_anticiporeserv.Text, @"^(\d{1,7})(\.\d{1,2}){0,1}$"))
                    {
                        if (Regex.IsMatch(txtbx_dinerofaltantereserv.Text, @"^(\d{1,7})(\.\d{1,2}){0,1}$"))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Dinero faltante no es un número");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El monto total no es un número");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Monto total no es un número valido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Número de personas no es un número");
                return false;
            }

        }

        private void From_Reservacion_Load(object sender, EventArgs e)
        {
            cbbx_tipodepagoreserv.Items.Add("Credito"); //Para agregar datos a un combobox
            cbbx_tipodepagoreserv.Items.Add("Debito");
            cbbx_tipodepagoreserv.Items.Add("Transferencia");

            // Load data for dgv_clientereserv
            //string consulta1 = "SELECT ID_cliente, ID_operativo_cliente, Nombre_cliente, ApellidoP_cliente, Nombre_calle_cliente," +
            //    " Numero_de_casa_cliente, Municipio_cliente, Código_postal_cliente, Ciudad_cliente, Estado_cliente, País_cliente," +
            //    " RFC_cliente, Fecha_de_Nacimiento_cliente, Estado_Civil_cliente, ID_cliente_contacto FROM dbo.DatosClientes";
            string consulta1 = "ObtenerDatosClientes";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);
            dgv_clientereserv.DataSource = dt1;

            // Load data for dgv_hotelreserv
            //string consulta2 = "SELECT ID_hotel, ID_admin_hotel, Nombre_hotel, Nombre_calle_hotel, Municipio_hotel, Código_postal_hotel, " +
            //    "Ciudad_hotel, Estado_hotel, País_hotel, Número_de_pisos_hotel, Número_de_habitaciones_hotel, Amenidades_hotel, " +
            //    "Zona_turística_hotel, Servicio_adicional_hotel, Sala_de_eventos_hotel, Teléfono_hotel " +
            //    "FROM dbo.DatosHoteles";
            string consulta2 = "ObtenerDatosHoteles";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(consulta2, conexion);
            DataTable dt2 = new DataTable();
            adaptador2.Fill(dt2);
            dgv_hotelreserv.DataSource = dt2;
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void llenar_tabla()
        {
            //string consulta1 = "select C.ID_cliente,C.ID_operativo_cliente,C.Nombre_cliente,C.ApellidoP_cliente,C.Nombre_calle_cliente," +
            //    "C.Numero_de_casa_cliente, C.Municipio_cliente, C.Código_postal_cliente, C.Ciudad_cliente, C.Estado_cliente,C.País_cliente, C.RFC_cliente," +
            //    " C.Fecha_de_Nacimiento_cliente, C.Estado_Civil_cliente,C.Fecha_y_hora_registro_cliente, O.ID_cliente_contacto    from Cliente C" +
            //    "join Cliente_Contacto O ON O.ID_cliente_contacto=C.ID_cliente_contacto " +
            //    "join Cliente_Referencia R ON R.ID_referencia_hotel=C.ID_referencia_hotel ";
            string consulta1 = "ObtenerDatosClientes2";
            SqlDataAdapter adaptador1 = new SqlDataAdapter(consulta1, conexion);
            DataTable dt1 = new DataTable();
            adaptador1.Fill(dt1);
            dgv_clientereserv.DataSource = dt1;

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuOperativo

            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correoactual);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
        }

        private void dgv_clientereserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_clientereserv.Rows.Count)
            {
                int IDcliente = Convert.ToInt32(dgv_clientereserv.Rows[e.RowIndex].Cells["ID_cliente"].Value);
                clienteID = IDcliente;
                string Nombrecliente = Convert.ToString(dgv_clientereserv.Rows[e.RowIndex].Cells["Nombre_cliente"].Value);
                MessageBox.Show("Cliente " + Nombrecliente + " ha sido seleccionado.");
            }
        }

        private void dgv_hotelreserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //           //llena de datos de la tabla habitacion al seleccionar el hotel que quiere reservar
            //           string consulta3 = "select Número_habitación, Habitación_creada_Admin, Tipo_de_habitación, ID_hotel_habitación," +
            //"Fecha_y_hora_registro_habitación from Habitación";
            //           SqlDataAdapter adaptador3 = new SqlDataAdapter(consulta3, conexion);
            //           DataTable dt3 = new DataTable();
            //           adaptador3.Fill(dt3);
            //           dgv_hotelreserv.DataSource = dt3;

            // Check if a valid row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgv_hotelreserv.Rows.Count)
            {
                // Get the selected hotel ID from the dgv_hotelreserv DataGridView
                int hotelID = Convert.ToInt32(dgv_hotelreserv.Rows[e.RowIndex].Cells["ID_hotel"].Value);
                HotelID = hotelID;
                string Nombrecliente = Convert.ToString(dgv_hotelreserv.Rows[e.RowIndex].Cells["Nombre_hotel"].Value);
                MessageBox.Show("Hotel " + Nombrecliente + " ha sido seleccionado.");
                conexion.Close();
                conexion.Open();

                using (SqlCommand command = new SqlCommand("Habitacioneshotel", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Hotel", hotelID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_tipohabitacionreserv.DataSource = dataTable;
                }

                using (SqlCommand command = new SqlCommand("CargarTipoHabitacionconHotelR", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_Hotel", hotelID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_tipotipo.DataSource = dataTable;
                }




                conexion.Close();
            }


            /*
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
             */

        }

        private void txtbx_filtrosreserv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_filtroreserv_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(HotelID.ToString()) && !string.IsNullOrEmpty(dttm_fechainicio.Value.ToString()) &&
                !string.IsNullOrEmpty(dateTimePicker1.Value.ToString()))
            {

                conexion.Open();

                using (SqlCommand command = new SqlCommand("Habitacionesdisponibles", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Inicio", dttm_fechainicio.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Salida", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Hotel", HotelID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_tipohabitacionreserv.DataSource = dataTable;
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Elija el hotel y las fechas para filtrar las habitaciones");
            }
        }

        private void dgv_tipohabitacionreserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_tipohabitacionreserv.Rows.Count)
            {
                int HabitID = Convert.ToInt32(dgv_tipohabitacionreserv.Rows[e.RowIndex].Cells["Número_habitación"].Value);
                HabitacionID = HabitID;
                string Nombrecliente = Convert.ToString(dgv_tipohabitacionreserv.Rows[e.RowIndex].Cells["Número_habitación"].Value);
                MessageBox.Show("Número " + Nombrecliente + " de habitación ha sido seleccionado.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_filtrosreserv.Text))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetClienteByRFC", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Rfc", txtbx_filtrosreserv.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_clientereserv.DataSource = dataTable;
                }
                conexion.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_filtrosreserv.Text))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetClienteByEmail", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Correo", txtbx_filtrosreserv.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_clientereserv.DataSource = dataTable;
                }
                conexion.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_filtrosreserv.Text))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetClienteByApellidos", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PAP", textBox1.Text);
                    command.Parameters.AddWithValue("@MAP", textBox2.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_clientereserv.DataSource = dataTable;
                }
                conexion.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_filtrosreserv.Text))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("GetHotelesCiudad", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Ciudad", textBox3.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_hotelreserv.DataSource = dataTable;
                }
                conexion.Close();
            }
        }

        private void btn_crearreservacion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_numpersonasreserv.ToString()) && !string.IsNullOrEmpty(HabitacionID.ToString()) && !string.IsNullOrEmpty(txtbx_anticiporeserv.Text))
            {
                if (HabitacionID > 0)
                {
                    conexion.Close();
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand("Monto", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Hab", HabitacionID.ToString());


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //CultureInfo c = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
                                //c.NumberFormat.CurrencyNegativePattern = 14; // From MSDN -- no enum values for this
                                //c.NumberFormat.CurrencySymbol = "USD";

                                //Obtener decimal de sql
                                decimal precionoche = decimal.Round(reader.GetDecimal(0), 2);

                                int personas = Int32.Parse(txtbx_numpersonasreserv.Text);

                                //decimal montototal = precionoche * personas;
                                decimal montototal = decimal.Round(precionoche * personas, 2);
                                txtbx_montototalreserv.Text = montototal.ToString();

                                //Obtener un dato y transformarlo en decimal en C#

                                //decimal anticipo = Decimal.Parse(txtbx_anticiporeserv.Text);
                                decimal anticipo = decimal.Round(decimal.Parse(txtbx_anticiporeserv.Text), 2);
                                decimal faltante = montototal - anticipo;



                                if (faltante < 0)
                                {
                                    MessageBox.Show("El anticipo supera el monto total");
                                }
                                else
                                {
                                    txtbx_dinerofaltantereserv.Text = faltante.ToString();
                                }

                            }

                        }
                    }
                    conexion.Close();
                }
            }
            if (Datosvacios())
            {
                if (Datosnum())
                {
                    conexion.Open();
                    decimal anticipo = decimal.Parse(txtbx_anticiporeserv.Text);
                    SqlParameter anticipoParam = new SqlParameter("@ANTICIPO", SqlDbType.Money);
                    anticipoParam.Value = anticipo;

                    /*System.Data.SqlClient.SqlException: 'The UPDATE statement conflicted with the FOREIGN KEY constraint "FK_NúmeroHabitaciónReservación". 
                     * The conflict occurred in database "master", table "dbo.Habitación", column 'Número_habitación'.
                    The statement has been terminated.'*/

                    SqlCommand InserReser = new SqlCommand("InsertReservación", conexion);
                    InserReser.CommandType = CommandType.StoredProcedure;
                    InserReser.Parameters.AddWithValue("@IDHAM", HabitacionID);
                    InserReser.Parameters.AddWithValue("@IDCLIE", clienteID);
                    InserReser.Parameters.AddWithValue("@IDHOTEL", HotelID);
                    InserReser.Parameters.AddWithValue("@ENTRADA", dttm_fechainicio.Value);
                    InserReser.Parameters.AddWithValue("@SALIDA", dateTimePicker1.Value);
                    InserReser.Parameters.AddWithValue("@PAGO", cbbx_tipodepagoreserv.Text);
                    InserReser.Parameters.AddWithValue("@NUMPERSONAS", txtbx_numpersonasreserv.Text);
                    InserReser.Parameters.Add(anticipoParam);

                    using (SqlDataReader reader = InserReser.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Guid codigoReservacion = reader.GetGuid(0);
                            MessageBox.Show("Código_reservación: " + codigoReservacion.ToString());
                        }
                    }

                    conexion.Close();

                }
                else
                {
                    MessageBox.Show("Reservación cancelada");
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos antes de crear la reservación");
            }
        }

        private void dgv_tipotipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_tipotipo.Rows.Count)
            {
                // Get the selected hotel ID from the dgv_hotelreserv DataGridView
                int TipID = Convert.ToInt32(dgv_tipotipo.Rows[e.RowIndex].Cells["Código_tipo_habitación"].Value);
                TipoID = TipID;
                if (TipoID != 0)
                {
                string Nombrecliente = Convert.ToString(dgv_tipotipo.Rows[e.RowIndex].Cells["Nivel_de_habitación_thabitación"].Value);
                MessageBox.Show("Tipo " + Nombrecliente + " ha sido seleccionado.");
                conexion.Open();

                using (SqlCommand command = new SqlCommand("CargarHabitacionesConTipo", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IDTIPO", TipoID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_tipohabitacionreserv.DataSource = dataTable;
                }
                }
                else
                {
                    MessageBox.Show("Para hacer la búsqueda de habitación, seleccione una celda valida de Tipo de habitación");
                }
               
            }
        }
    }
}
