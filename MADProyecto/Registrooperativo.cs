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
    public partial class Form_Registrooperativo : Form
    {
        private string correo;
        public Form_Registrooperativo(string correoactual)
        {
            this.correo = correoactual;
            InitializeComponent();
        }

        //iniciar la conexion en que servidor la base de datos 
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Registrooperativo_Load(object sender, EventArgs e)
        {
            
        }

        public bool Datosvacios()
        {
            if (string.IsNullOrEmpty(txtbx_correoop.Text) || string.IsNullOrEmpty(txtbx_contrasenaop.Text) || string.IsNullOrEmpty(txtbx_nombreop.Text) ||
            string.IsNullOrEmpty(txtbx_apellidopop.Text) || string.IsNullOrEmpty(txtbx_apellidomop.Text) || string.IsNullOrEmpty(dttm_fechanacimientoop.Text) ||
            string.IsNullOrEmpty(txtbx_nombrecalleop.Text) || string.IsNullOrEmpty(txtbx_numcasaop.Text) || string.IsNullOrEmpty(txtbx_municipioop.Text) ||
            string.IsNullOrEmpty(txtbx_codigopostalop.Text) || string.IsNullOrEmpty(txtbx_ciudadop.Text) || string.IsNullOrEmpty(txtbx_estadoop.Text) ||
            string.IsNullOrEmpty(txtbx_paisop.Text) || string.IsNullOrEmpty(txtbx_numnominaop.Text) ||
            string.IsNullOrEmpty(txtbx_telcasaop.Text) || string.IsNullOrEmpty(txtbx_telcelop.Text))
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
            if (Regex.IsMatch(txtbx_numcasaop.Text, @"^[0-9]+$"))
            {
                if (Regex.IsMatch(txtbx_codigopostalop.Text, @"^[0-9]+$"))
                {
                    if (Regex.IsMatch(txtbx_numnominaop.Text, @"^[0-9]+$"))
                    {
                        if (Regex.IsMatch(txtbx_telcasaop.Text, @"^[0-9]+$"))
                        {
                            if (Regex.IsMatch(txtbx_telcelop.Text, @"^[0-9]+$"))
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Teléfono de celular no es un número");
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Teléfono de casa no es un número");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Número de nomina no es un número");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Código Postal no es un número valido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Número de casa no es un número");
                return false;
            }

        }

        public void limpiar_campos()
        {
            txtbx_correoop.Clear();
            txtbx_contrasenaop.Clear();
            txtbx_nombreop.Clear();
            txtbx_apellidopop.Clear();
            txtbx_apellidomop.Clear();
            txtbx_nombrecalleop.Clear();
            txtbx_numcasaop.Clear();
            txtbx_municipioop.Clear();
            txtbx_codigopostalop.Clear();
            txtbx_ciudadop.Clear();
            txtbx_estadoop.Clear();
            txtbx_idop.Clear();
            txtbx_paisop.Clear();
            txtbx_numnominaop.Clear();
            txtbx_telcasaop.Clear();
            txtbx_telcelop.Clear();
        }
        private void btn_registrarop_Click(object sender, EventArgs e)
        {
            // string Dato = entradaUsuario.GetCorreoIniciador();//CORREO DEL USUARIO ACTUAL
            conexion.Close();

            conexion.Open();

            //Si algún dato está vacío
            if (Datosvacios())
            {
                if (Datosnum())
                {
 SqlCommand comando = new SqlCommand("QueNoSeRepita", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Correo", txtbx_correoop.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtbx_contrasenaop.Text);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                //Comprobación de datos únicos
                if (lector.HasRows == false)
                {
                    lector.Close();
                    //Todo validado para registrar

                    SqlCommand consul = new SqlCommand("InsertData", conexion);
                    consul.CommandType = CommandType.StoredProcedure;
                    consul.Parameters.AddWithValue("@Teléfono_Casa", txtbx_telcasaop.Text);
                    consul.Parameters.AddWithValue("@Teléfono_Celular", txtbx_telcelop.Text);
                    consul.Parameters.AddWithValue("@Correo_electrónico", txtbx_correoop.Text);
                    consul.Parameters.AddWithValue("@Contraseña", txtbx_contrasenaop.Text);
                    consul.Parameters.AddWithValue("@Nombre", txtbx_nombreop.Text);
                    consul.Parameters.AddWithValue("@ApellidoP", txtbx_apellidopop.Text);
                    consul.Parameters.AddWithValue("@ApellidoM", txtbx_apellidomop.Text);
                    consul.Parameters.AddWithValue("@Nombre_calle", txtbx_nombrecalleop.Text);
                    consul.Parameters.AddWithValue("@Numero_de_casa", txtbx_numcasaop.Text);
                    consul.Parameters.AddWithValue("@Municipio", txtbx_municipioop.Text);
                    consul.Parameters.AddWithValue("@Código_postal", txtbx_codigopostalop.Text);
                    consul.Parameters.AddWithValue("@Ciudad", txtbx_ciudadop.Text);
                    consul.Parameters.AddWithValue("@Estado", txtbx_estadoop.Text);
                    consul.Parameters.AddWithValue("@País", txtbx_paisop.Text);
                    consul.Parameters.AddWithValue("@Número_de_nomina", txtbx_numnominaop.Text);
                    consul.Parameters.AddWithValue("@Fecha_de_Nacimiento", dttm_fechanacimientoop.Value);
                    consul.Parameters.AddWithValue("@Correo_electrónico_admin", correo);

                    SqlDataReader reader23;
                    reader23 = consul.ExecuteReader();
                    if (!reader23.HasRows)
                    {
                        MessageBox.Show("Registro agregado");
                    }

                    limpiar_campos();
                    conexion.Close();
                }
               

                }
                else
                {
                    MessageBox.Show("El correo electrónico o la contraseña propuesta no están disponibles, cambie los datos");
                    txtbx_contrasenaop.Text = string.Empty;
                    txtbx_correoop.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Complete los campos, por favor");
            }
        }
        /*
        //private void btn_editarop_Click(object sender, EventArgs e)
        //{
        //    conexion.Close();
        //    conexion.Open();

        //    //Si algún dato está vacío
        //    if (Datosvacios())
        //    {
        //        string cons1 = "SELECT U.Correo_electrónico, U.Contraseña " +
        //                       "FROM Usuario U " +
        //                       "JOIN Operativo O ON U.Correo_electrónico = O.Correo_electrónico " +
        //                       "WHERE O.ID_operativo = @ID_operativo";

        //        using (SqlCommand comando1 = new SqlCommand(cons1, conexion))
        //        {
        //            comando1.Parameters.AddWithValue("@ID_operativo", txtbx_idop.Text);

        //            using (SqlDataReader reader = comando1.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    string correoigual = reader.GetString(0);
        //                    string contraseñaigual = reader.GetString(1);

        //                    if (txtbx_correoop.Text == correoigual && txtbx_contrasenaop.Text == contraseñaigual)
        //                    {
        //                        string consulta1 = "EXEC UpdateOperativoData @ID_operativo = @IDOperativo, " +
        //                                           "@Teléfono_Casa = @TeléfonoCasa, " +
        //                                           "@Teléfono_Celular = @TeléfonoCelular, " +
        //                                           "@Correo_electrónico_teléfono = @CorreoElectrónicoTeléfono, " +
        //                                           "@Contraseña = @Contraseña, " +
        //                                           "@Nombre = @Nombre, " +
        //                                           "@ApellidoP = @ApellidoP, " +
        //                                           "@ApellidoM = @ApellidoM, " +
        //                                           "@Nombre_calle = @NombreCalle, " +
        //                                           "@Numero_de_casa = @NumeroCasa, " +
        //                                           "@Municipio = @Municipio, " +
        //                                           "@Código_postal = @CódigoPostal, " +
        //                                           "@Ciudad = @Ciudad, " +
        //                                           "@Estado = @Estado, " +
        //                                           "@País = @País, " +
        //                                           "@Número_de_nomina = @NúmeroNomina, " +
        //                                           "@Fecha_de_Nacimiento = @FechaNacimiento, " +
        //                                           "@Correo_electrónico_admin = @CorreoElectrónicoAdmin";

        //                        using (SqlCommand command = new SqlCommand(consulta1, conexion))
        //                        {
        //                            command.Parameters.AddWithValue("@IDOperativo", txtbx_idop.Text);
        //                            command.Parameters.AddWithValue("@TeléfonoCasa", txtbx_telcasaop.Text);
        //                            command.Parameters.AddWithValue("@TeléfonoCelular", txtbx_telcelop.Text);
        //                            command.Parameters.AddWithValue("@CorreoElectrónicoTeléfono", txtbx_correoop.Text);
        //                            command.Parameters.AddWithValue("@Contraseña", txtbx_contrasenaop.Text);
        //                            command.Parameters.AddWithValue("@Nombre", txtbx_nombreop.Text);
        //                            command.Parameters.AddWithValue("@ApellidoP", txtbx_apellidopop.Text);
        //                            command.Parameters.AddWithValue("@ApellidoM", txtbx_apellidomop.Text);
        //                            command.Parameters.AddWithValue("@NombreCalle", txtbx_nombrecalleop.Text);
        //                            command.Parameters.AddWithValue("@NumeroCasa", txtbx_numcasaop.Text);
        //                            command.Parameters.AddWithValue("@Municipio", txtbx_municipioop.Text);
        //                            command.Parameters.AddWithValue("@CódigoPostal", txtbx_codigopostalop.Text);
        //                            command.Parameters.AddWithValue("@Ciudad", txtbx_ciudadop.Text);
        //                            command.Parameters.AddWithValue("@Estado", txtbx_estadoop.Text);
        //                            command.Parameters.AddWithValue("@País", txtbx_paisop.Text);
        //                            command.Parameters.AddWithValue("@NúmeroNomina", decimal.Parse(txtbx_numnominaop.Text));
        //                            command.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(dttm_fechanacimientoop.Text));
        //                            command.Parameters.AddWithValue("@CorreoElectrónicoAdmin", correo);

        //                            int rows = command.ExecuteNonQuery();
        //                            if (rows == 0)
        //                            {
        //                                MessageBox.Show("Registro actualizado");
        //                                limpiar_campos();
        //                            }
        //                            else
        //                            {
        //                                MessageBox.Show("Error");
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("El correo electrónico o la contraseña propuesta no están disponibles, cambie los datos");
        //                        txtbx_contrasenaop.Text = string.Empty;
        //                        txtbx_correoop.Text = string.Empty;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Complete los campos, por favor");
        //    }

        //}
        */
        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_idop.Text))
            {
                if (Datosnum())
                {

                conexion.Close();
                conexion.Open();
                int pasador = Int32.Parse(txtbx_idop.Text);
                string consultaID = "EXEC GetOperativoUsuario  @ID_Operativo=" + pasador;

                // Create the SqlCommand object with the stored procedure name
                using (SqlCommand comando1 = new SqlCommand("GetOperativoUsuario", conexion))
                {
                    comando1.CommandType = CommandType.StoredProcedure;

                    // Add the ID_Operativo parameter to the command
                    comando1.Parameters.Add(new SqlParameter("@ID_Operativo", SqlDbType.Int)
                    {
                        Value = pasador
                    });

                    // Execute the command and retrieve the result set
                    using (SqlDataReader reader = comando1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the returned data and assign it to variables
                            string correoElectronico = reader.GetString(0);
                            string contraseña = reader.GetString(1);
                            string nombre = reader.GetString(2);
                            string apellidoP = reader.GetString(3);
                            string apellidoM = reader.GetString(4);
                            DateTime fechaNacimiento = reader.GetDateTime(5);
                            string nombrecalle = reader.GetString(6);
                            int numerodecasa = reader.GetInt32(7);
                            string municipio = reader.GetString(8);
                            string codigopostal = reader.GetString(9);
                            string ciudad = reader.GetString(10);
                            string estado = reader.GetString(11);
                            string pais = reader.GetString(12);
                            decimal numerodenomina = reader.GetDecimal(13);
                            string telefonoCasa = reader.GetString(14);
                            string telefonoCelular = reader.GetString(15);

                            txtbx_correoop.Text = correoElectronico;
                            txtbx_contrasenaop.Text = contraseña;
                            txtbx_nombreop.Text = nombre;
                            txtbx_apellidopop.Text = apellidoP;
                            txtbx_apellidomop.Text = apellidoM;
                            dttm_fechanacimientoop.Value = fechaNacimiento;
                            txtbx_nombrecalleop.Text = nombrecalle;
                            txtbx_numcasaop.Text = numerodecasa.ToString();
                            txtbx_municipioop.Text = municipio;
                            txtbx_codigopostalop.Text = codigopostal;
                            txtbx_ciudadop.Text = ciudad;
                            txtbx_estadoop.Text = estado;
                            txtbx_paisop.Text = pais;
                            txtbx_numnominaop.Text = numerodenomina.ToString();
                            txtbx_telcasaop.Text = telefonoCasa;
                            txtbx_telcelop.Text = telefonoCelular;
                        }
                    }
                }
                }
            }
            else
            {
                MessageBox.Show("Para buscar por favor de poner el Id del Operativo");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MenuAdmin AbrirMenuAdmin = new MenuAdmin(correo);
            this.Hide();
            AbrirMenuAdmin.ShowDialog();
        }

        private void btn_eliminarop_Click(object sender, EventArgs e)
        {

        }
    }
}
