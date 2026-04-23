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
    //Hacer una búsqueda por hotel
    public partial class Form_Habitacion : Form
    {
        private string correo;
        private string idTipo;
        private int TipoID;
        public Form_Habitacion(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }

        //iniciar la conexion en que servidor la base de datos 
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        public void llenar_tabla()
        {
            //string consulta = "select Código_tipo_habitación, Número_de_camas_thabitación, Tipo_de_camas_thabitación, Precio_por_noche_por_persona_thabitación," +
            //    "Número_de_personas_thabitación, Nivel_de_habitación_thabitación, Características_thabitación, Amenidades_thabitación," +
            //    "Vista_al_frente_thabitación from Tipo_de_Habitación";
            string consulta = "ObtenerTiposDeHabitacion";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgv_tipohabitacion.DataSource = dt;
        }

        public bool Checarhotel()
        {
            conexion.Close();
            conexion.Open();
            string consulta = "VerificarHotel";
            SqlCommand Hotelconsul = new SqlCommand(consulta, conexion);
            Hotelconsul.CommandType = CommandType.StoredProcedure;
            SqlDataReader lector;
            lector = Hotelconsul.ExecuteReader();

            //checar la existencia de si hay hoteles
            if (lector.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void limpiar_campos()
        {
            txtbx_numcamasth.Clear();
            txtbx_tipodecamath.Clear();
            txtbx_precionxpth.Clear();
            txtbx_numpersonasth.Clear();
            txtbx_nvlth.Clear();
            txtbx_caracteristicasth.Clear();
            txtbx_amenidadesth.Clear();
            txtbx_vistasth.Clear();
            txtbx_codigoth.Clear();
            txtbx_nombrehotelth.Clear();
        }

        private void Form_Habitacion_Load(object sender, EventArgs e)
        {
            if (Checarhotel())
            {
                conexion.Close();
                conexion.Open();
                string consulta = "ObtenerTiposDeHabitacion";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgv_tipohabitacion.DataSource = dt;
                conexion.Close();
            }
            else
            {
                MessageBox.Show("No hay hoteles registrados en la base de datos, regrese a registrar uno. Tipo de Habitación no estará disponible.");
            }

        }

        private void btn_registrotipohabitacion_Click(object sender, EventArgs e)
        {
            conexion.Close();
            conexion.Open();

            if (Checarhotel())
            {
                if (string.Compare(txtbx_vistasth.Text, "Y") ==0 || string.Compare(txtbx_vistasth.Text, "N")==0)
                {
                string consulta = "InsertarTipoHabitacion";
                SqlCommand comando1 = new SqlCommand(consulta, conexion);
                    comando1.CommandType = CommandType.StoredProcedure;

                //Agregado
                comando1.Parameters.AddWithValue("@numcamas", txtbx_numcamasth.Text);
                comando1.Parameters.AddWithValue("@tipocama", txtbx_tipodecamath.Text);
                comando1.Parameters.AddWithValue("@precio", txtbx_precionxpth.Text);
                comando1.Parameters.AddWithValue("@numpersonas", txtbx_numpersonasth.Text);
                comando1.Parameters.AddWithValue("@nivel", txtbx_nvlth.Text);
                comando1.Parameters.AddWithValue("@caracteristicas", txtbx_caracteristicasth.Text);
                comando1.Parameters.AddWithValue("@amenidades", txtbx_amenidadesth.Text);
                comando1.Parameters.AddWithValue("@vistas", txtbx_vistasth.Text);
                comando1.Parameters.AddWithValue("@Hotel", txtbx_nombrehotelth.Text);


                comando1.ExecuteNonQuery();
                MessageBox.Show("Registro agregado");
                llenar_tabla();
                limpiar_campos();
                conexion.Close();
                }
                else
                {
                    MessageBox.Show("Vistas tiene que ser Y o N");
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("No hay hoteles registrados en la base de datos, regrese a registrar uno. Tipo de Habitación no estará disponible.");
            }
            
            
        }

        private void btn_eliminarth_Click(object sender, EventArgs e)
        {

            if (Checarhotel())
            {
                conexion.Open();
                string consulta = "EliminarTipoDeHabitacion";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodigoTipoHabitacion", txtbx_codigoth.Text);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Fila eliminada");
                }

                llenar_tabla();
                limpiar_campos();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("No hay hoteles registrados en la base de datos, regrese a registrar uno. Tipo de Habitación no estará disponible.");
            }
            
        }

        private void btn_editarth_Click(object sender, EventArgs e)
        {
            conexion.Close();
            conexion.Open();
            if (Checarhotel())
            {

                if (!string.IsNullOrEmpty(idTipo))
                {

                    if (string.Compare(txtbx_vistasth.Text, "Y") == 0 || string.Compare(txtbx_vistasth.Text, "N") == 0)
                    {
                        
                        if (int.TryParse(idTipo, out var result))
                        {
                            TipoID = result;
                        }

                        string consulta = "ActualizarTipoDeHabitacion";
                        SqlCommand comando = new SqlCommand(consulta, conexion);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Hotel", txtbx_nombrehotelth.Text);
                        comando.Parameters.AddWithValue("@NumCamas", txtbx_numcamasth.Text);
                        comando.Parameters.AddWithValue("@TipoCamas", txtbx_tipodecamath.Text);
                        comando.Parameters.AddWithValue("@PrecioNoche", txtbx_precionxpth.Text);
                        comando.Parameters.AddWithValue("@NumPersonas", txtbx_numpersonasth.Text);
                        comando.Parameters.AddWithValue("@NivelHabitacion", txtbx_nvlth.Text);
                        comando.Parameters.AddWithValue("@Caracteristicas", txtbx_caracteristicasth.Text);
                        comando.Parameters.AddWithValue("@Amenidades", txtbx_amenidadesth.Text);
                        comando.Parameters.AddWithValue("@VistaFrente", txtbx_vistasth.Text);
                        comando.Parameters.AddWithValue("@CodigoTipoHabitacion", TipoID);


                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro modificado");
                        }

                        llenar_tabla();
                        limpiar_campos();
                        conexion.Close();

                    }
                    else
                    {
                        MessageBox.Show("Vistas tiene que ser Y o N");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el Tipo de Habitación a editar");
                }
                 
                   
            }
            else
            {
                MessageBox.Show("No hay hoteles registrados en la base de datos, regrese a registrar uno. Tipo de Habitación no estará disponible.");
            }
            conexion.Close();
           
        }

        private void txtbx_codigoth_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_tipohabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_numcamasth.Text = dgv_tipohabitacion.SelectedCells[1].Value.ToString();
            txtbx_tipodecamath.Text = dgv_tipohabitacion.SelectedCells[2].Value.ToString();
            txtbx_precionxpth.Text = dgv_tipohabitacion.SelectedCells[3].Value.ToString();
            txtbx_numpersonasth.Text = dgv_tipohabitacion.SelectedCells[4].Value.ToString();
            txtbx_nvlth.Text = dgv_tipohabitacion.SelectedCells[5].Value.ToString();
            txtbx_caracteristicasth.Text = dgv_tipohabitacion.SelectedCells[6].Value.ToString();
            txtbx_amenidadesth.Text = dgv_tipohabitacion.SelectedCells[7].Value.ToString();
            txtbx_vistasth.Text = dgv_tipohabitacion.SelectedCells[8].Value.ToString();
            txtbx_nombrehotelth.Text = dgv_tipohabitacion.SelectedCells[9].Value.ToString();
            txtbx_codigoth.Text = dgv_tipohabitacion.SelectedCells[9].Value.ToString();

            if (e.RowIndex >= 0 && e.RowIndex < dgv_tipohabitacion.Rows.Count)
            {
                string IDTipoHabitación = Convert.ToString(dgv_tipohabitacion.Rows[e.RowIndex].Cells["Código_tipo_habitación"].Value);
                idTipo = IDTipoHabitación;
                MessageBox.Show("Tipo de Habitación seleccionada");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Volver a la ventana MenuAdmin
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correo);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }

        private void dgv_tipohabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbx_nvlth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
