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
using System.IO;
using System.Configuration;


namespace MADProyectoEneJun2023
{
    public partial class Factura : Form
    {
        private string correo;

        public Factura(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }
        //iniciar la conexion en que servidor la base de datos 
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void Factura_Load(object sender, EventArgs e)
        {
            string consulta = "CargarFactura";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            // Register the CellFormatting event handler before setting the DataSource
            //dgv_reservacionfactura.CellFormatting += dgv_reservacionfactura_CellFormatting;

            dgv_reservacionfactura.DataSource = dt;
        }



        //private void dgv_reservacionfactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_reservacionfactura.Columns[e.ColumnIndex].Name == "ServiciosUsados")
        //    {
        //        // Get the original value from the data source
        //        int serviciosUsados = Convert.ToInt32(dgv_reservacionfactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

        //        // Modify the displayed value based on the original value
        //        string displayedValue = serviciosUsados == 0 ? "$0" : "$500";

        //        // Set the modified value for display
        //        e.Value = displayedValue;
        //        e.FormattingApplied = true;
        //    }
        //}


        //private void dgv_hotelreserv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgv_reservacionfactura.Columns[e.ColumnIndex].Name == "ServiciosUsados")
        //    {
        //        // Get the original value from the data source
        //        int serviciosUsados = Convert.ToInt32(dgv_reservacionfactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

        //        // Modify the displayed value based on the original value
        //        string displayedValue = serviciosUsados == 0 ? "$0" : "$500";

        //        // Set the modified value for display
        //        e.Value = displayedValue;
        //        e.FormattingApplied = true;
        //    }
        //}


        //private void Factura_Load(object sender, EventArgs e)
        //{
        //    string consulta = "CargarFactura";
        //    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
        //    DataTable dt = new DataTable();
        //    adaptador.Fill(dt);
        //    dgv_reservacionfactura.DataSource = dt;
        //    dgv_reservacionfactura.CellFormatting += dgv_hotelreserv_CellFormatting;

        //}

        private void dgv_reservacionfactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_reservacionfactura.Rows.Count)
            {
                // Get the selected hotel ID from the dgv_hotelreserv DataGridView
                Guid Código_reservación = new Guid(dgv_reservacionfactura.Rows[e.RowIndex].Cells["Código_reservación"].Value.ToString());
                txtbx_codigoreserv.Text = Código_reservación.ToString();

            }
        }

        private void dgv_reservacionfactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_codigoreserv.Text = dgv_reservacionfactura.SelectedCells[0].Value.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

            //Volver a la ventana MenuOperativo
            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correo);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
            
        }

        private void GenerarArchivoFactura(string codigoReservacion)
        {
            // Consultar los datos de la reserva específica

            string consulta = "FacturaSeleccionada";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigoReservacion", codigoReservacion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            // Verificar si se encontraron datos
            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                // Obtener los valores de las columnas
                string numeroHabitacion = fila["Número_habitación_reservación"].ToString();
                string idCliente = fila["ID_cliente_reservación"].ToString();
                string idHotel = fila["ID_hotel_reservación"].ToString();
                string fechaCreacion = fila["Fecha_creación_reservación"].ToString();
                string fechaEntrada = fila["Fecha_entrada_reservación"].ToString();
                string fechaSalida = fila["Fecha_salida_reservación"].ToString();
                string tipoPago = fila["Tipo_de_pago"].ToString();
                string fechaHoraRegistro = fila["Fecha_y_hora_registro_reservación"].ToString();
                string rangoFechas = fila["Rango_de_fechas"].ToString();
                string dineroFaltante = fila["Dinero_faltante"].ToString();
                string anticipoReservacion = fila["Anticipo_de_reservación"].ToString();
                string montoTotal = fila["Monto_total"].ToString();
                string numPersonasHabitacion = fila["Número_de_personas_en_habitación_reservación"].ToString();

                // Generar el archivo de factura
                string nombreArchivo = "factura_" + codigoReservacion + ".txt"; // Nombre del archivo de factura
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    sw.WriteLine("***** FACTURA *****");
                    sw.WriteLine("Código de Reservación: " + codigoReservacion);
                    sw.WriteLine("Número de Habitación: " + numeroHabitacion);
                    sw.WriteLine("ID Cliente: " + idCliente);
                    sw.WriteLine("ID Hotel: " + idHotel);
                    sw.WriteLine("Fecha de Creación: " + fechaCreacion);
                    sw.WriteLine("Fecha de Entrada: " + fechaEntrada);
                    sw.WriteLine("Fecha de Salida: " + fechaSalida);
                    sw.WriteLine("Tipo de Pago: " + tipoPago);
                    sw.WriteLine("Fecha y Hora de Registro: " + fechaHoraRegistro);
                    sw.WriteLine("Rango de Fechas: " + rangoFechas);
                    sw.WriteLine("Dinero Faltante: " + dineroFaltante);
                    sw.WriteLine("Anticipo de Reservación: " + anticipoReservacion);
                    sw.WriteLine("Monto Total: " + montoTotal);
                    sw.WriteLine("Número de Personas en la Habitación: " + numPersonasHabitacion);
                }

                MessageBox.Show("Archivo de factura generado exitosamente.", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró la reservación con el código especificado.", "Reservación no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            string codigoReservacion = txtbx_codigoreserv.Text;
            GenerarArchivoFactura(codigoReservacion);

        }
    }
}
