using MADProyectoEneJun2023.Resources;
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
using System.Configuration;

namespace MADProyectoEneJun2023
{
    public partial class Form_Registrocliente : Form
    {
        private string correoactual;
        private string correocliente;
        public Form_Registrocliente(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        public void limpiar_campos()
        {
            txtbx_nombrecliente.Clear();
            txtbx_apellidopcliente.Clear();
            txtbx_apellidomcliente.Clear();
            txtbx_estadocivilcliente.Clear();
            txtbx_nombrecallecliente.Clear();
            txtbx_numcasacliente.Clear();
            txtbx_municipiocliente.Clear();
            txtbx_codigopostalcliente.Clear();
            txtbx_ciudadcliente.Clear();
            txtbx_estadocliente.Clear();
            txtbx_paiscliente.Clear();
            txtbx_correocliente.Clear();
            txtbx_telcasacliente.Clear();
            txtbx_telcelcliente.Clear();
            txtbx_idop.Clear();
            Referenciahotel.Clear();
            dttm_fechanacimientocliente.Value = DateTimePicker.MinimumDateTime;
        }
        private void Form_Registrocliente_Load(object sender, EventArgs e)
        {

        }
        public bool Datosvacios()
        {
            if (string.IsNullOrEmpty(txtbx_nombrecliente.Text) || string.IsNullOrEmpty(txtbx_apellidopcliente.Text) || string.IsNullOrEmpty(txtbx_apellidomcliente.Text) ||
                string.IsNullOrEmpty(dttm_fechanacimientocliente.Text) || string.IsNullOrEmpty(txtbx_rfccliente.Text) || string.IsNullOrEmpty(txtbx_estadocivilcliente.Text) ||
                string.IsNullOrEmpty(txtbx_nombrecallecliente.Text) || string.IsNullOrEmpty(txtbx_numcasacliente.Text) || string.IsNullOrEmpty(txtbx_municipiocliente.Text) ||
                string.IsNullOrEmpty(txtbx_codigopostalcliente.Text) || string.IsNullOrEmpty(txtbx_ciudadcliente.Text) || string.IsNullOrEmpty(txtbx_estadocliente.Text) ||
                string.IsNullOrEmpty(txtbx_paiscliente.Text) || string.IsNullOrEmpty(txtbx_correocliente.Text) || string.IsNullOrEmpty(txtbx_telcasacliente.Text) ||
                string.IsNullOrEmpty(txtbx_telcelcliente.Text) || string.IsNullOrEmpty(Referenciahotel.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_registrarcliente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (Datosvacios())
            {
                

                    using (SqlCommand command = new SqlCommand("InsertCliente", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombrecliente", txtbx_nombrecliente.Text);
                    command.Parameters.AddWithValue("@Pcliente", txtbx_apellidopcliente.Text);
                    command.Parameters.AddWithValue("@Mcliente", txtbx_apellidomcliente.Text);
                    command.Parameters.AddWithValue("@nombrecallecl", txtbx_nombrecallecliente.Text);
                    command.Parameters.AddWithValue("@numcasacl", txtbx_numcasacliente.Text);
                    command.Parameters.AddWithValue("@municipiocliente", txtbx_municipiocliente.Text);
                    command.Parameters.AddWithValue("@codposcliente", txtbx_codigopostalcliente.Text);
                    command.Parameters.AddWithValue("@ciudadcliente", txtbx_ciudadcliente.Text);
                    command.Parameters.AddWithValue("@estadocliente", txtbx_estadocliente.Text);
                    command.Parameters.AddWithValue("@paíscliente", txtbx_paiscliente.Text);
                    command.Parameters.AddWithValue("@rfccliente", txtbx_rfccliente.Text);
                    command.Parameters.AddWithValue("@nacimientocliente", dttm_fechanacimientocliente.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@estadocivilcl", txtbx_estadocivilcliente.Text);
                    command.Parameters.AddWithValue("@Teléfono_Casa", txtbx_telcasacliente.Text);
                    command.Parameters.AddWithValue("@Teléfono_Celular", txtbx_telcelcliente.Text);
                    command.Parameters.AddWithValue("@Correocliente", txtbx_correocliente.Text);
                    command.Parameters.AddWithValue("@Referencia", Referenciahotel.Text);
                    command.Parameters.AddWithValue("@Correo_electrónico_operativo", correoactual);

                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Falla con el registro, verifique los datos y la conexión");
                    }
                    else
                    {
                        MessageBox.Show("Cliente Registrado con exito");
                        limpiar_campos();
                    }
                }

            }
            else
            {
                MessageBox.Show("Complete los campos, por favor");
            }
            conexion.Close();
        }

        private void btn_editarcliente_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (Datosvacios())
            {
                if (correocliente != txtbx_correocliente.Text)
                {
                    using (SqlCommand command = new SqlCommand("VerificarCorreoCliente", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Correo", txtbx_nombrecliente.Text);

                        int rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Correo electrónico ya registrado, cambie el correo");
                          
                        }
                        else
                        {
                              using (SqlCommand comando3 = new SqlCommand("Actualizarclientes", conexion))
                            {
                                comando3.CommandType = CommandType.StoredProcedure;
                                comando3.Parameters.AddWithValue("@Nombre", txtbx_nombrecliente.Text);
                                comando3.Parameters.AddWithValue("@ApePat", txtbx_apellidopcliente.Text);
                                comando3.Parameters.AddWithValue("@ApeMat", txtbx_apellidomcliente.Text);
                                comando3.Parameters.AddWithValue("@NomCalle", txtbx_nombrecallecliente.Text);
                                comando3.Parameters.AddWithValue("@NumCasa", txtbx_numcasacliente.Text);
                                comando3.Parameters.AddWithValue("@Municipio", txtbx_municipiocliente.Text);
                                comando3.Parameters.AddWithValue("@CodPos", txtbx_codigopostalcliente.Text);
                                comando3.Parameters.AddWithValue("@Ciudad", txtbx_ciudadcliente.Text);
                                comando3.Parameters.AddWithValue("@Estado", txtbx_estadocliente.Text);
                                comando3.Parameters.AddWithValue("@Pais", txtbx_paiscliente.Text);
                                comando3.Parameters.AddWithValue("@RFC", txtbx_rfccliente.Text);
                                comando3.Parameters.AddWithValue("@Nacimiento", dttm_fechanacimientocliente.Value.ToString("yyyy-MM-dd"));
                                comando3.Parameters.AddWithValue("@Civil", txtbx_estadocivilcliente.Text);
                                comando3.Parameters.AddWithValue("@TelCasa", txtbx_telcasacliente.Text);
                                comando3.Parameters.AddWithValue("@TelCelular", txtbx_telcelcliente.Text);
                                comando3.Parameters.AddWithValue("@Email", txtbx_correocliente.Text);
                                comando3.Parameters.AddWithValue("@EmailOG", correocliente);
                                comando3.Parameters.AddWithValue("@Referencia", Referenciahotel.Text);
                                comando3.Parameters.AddWithValue("@IDOPERA", correoactual);

                                int rows2 = comando3.ExecuteNonQuery();
                                if (rows2 > 0)
                                {
                                    MessageBox.Show("Falla con el registro, verifique los datos y la conexión");
                                }
                                else
                                {
                                    MessageBox.Show("Cliente Actualizado con exito");
                                    limpiar_campos();
                                }
                            }
                        }
                    }


                }
                else
                {
                    using (SqlCommand comando5 = new SqlCommand("Actualizarclientes", conexion))
                    {
                        comando5.CommandType = CommandType.StoredProcedure;
                        comando5.Parameters.AddWithValue("@Nombre", txtbx_nombrecliente.Text);
                        comando5.Parameters.AddWithValue("@ApePat", txtbx_apellidopcliente.Text);
                        comando5.Parameters.AddWithValue("@ApeMat", txtbx_apellidomcliente.Text);
                        comando5.Parameters.AddWithValue("@NomCalle", txtbx_nombrecallecliente.Text);
                        comando5.Parameters.AddWithValue("@NumCasa", txtbx_numcasacliente.Text);
                        comando5.Parameters.AddWithValue("@Municipio", txtbx_municipiocliente.Text);
                        comando5.Parameters.AddWithValue("@CodPos", txtbx_codigopostalcliente.Text);
                        comando5.Parameters.AddWithValue("@Ciudad", txtbx_ciudadcliente.Text);
                        comando5.Parameters.AddWithValue("@Estado", txtbx_estadocliente.Text);
                        comando5.Parameters.AddWithValue("@Pais", txtbx_paiscliente.Text);
                        comando5.Parameters.AddWithValue("@RFC", txtbx_rfccliente.Text);
                        comando5.Parameters.AddWithValue("@Nacimiento", dttm_fechanacimientocliente.Value.ToString("yyyy-MM-dd"));
                        comando5.Parameters.AddWithValue("@Civil", txtbx_estadocivilcliente.Text);
                        comando5.Parameters.AddWithValue("@TelCasa", txtbx_telcasacliente.Text);
                        comando5.Parameters.AddWithValue("@TelCelular", txtbx_telcelcliente.Text);
                        comando5.Parameters.AddWithValue("@Email", txtbx_correocliente.Text);
                        comando5.Parameters.AddWithValue("@Referencia", Referenciahotel.Text);
                        comando5.Parameters.AddWithValue("@IDOPERA", correoactual);

                        int rows4 = comando5.ExecuteNonQuery();
                        if (rows4 > 0)
                        {
                            MessageBox.Show("Falla con el registro, verifique los datos y la conexión");
                        }
                        else
                        {
                            MessageBox.Show("Cliente Actualizado con exito");
                            limpiar_campos();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos, por favor");
            }

            conexion.Close();
        } 


        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Volver a la ventana Operativo

            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correoactual);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
        }

        private void dttm_fechanacimientocliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_idop.Text))
            {
                conexion.Open();

                using (SqlCommand command = new SqlCommand("EliminarCliente", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", txtbx_idop.Text);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Cliente eliminado con exito");
                        }
                        else
                        {
                            MessageBox.Show("Id de cliente no encontrado. Ingrese un Id valido");
                        }
                    }
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Para eliminar cliente busque primero el Id que le pertenece");

            }
        }

        private void txtbx_nombrecliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            conexion.Open();

            if (!string.IsNullOrEmpty(txtbx_idop.Text))
            {

                // Create the SqlCommand object with the stored procedure name
                using (SqlCommand comando1 = new SqlCommand("GetClienteByEmail", conexion))
                {
                    comando1.CommandType = CommandType.StoredProcedure;

                    // Add the ID_Operativo parameter to the command
                    comando1.Parameters.AddWithValue("@Correo", txtbx_idop.Text);


                    // Execute the command and retrieve the result set
                    using (SqlDataReader reader = comando1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the returned data and assign it to variables
                            string Nombre = reader.GetString(0);
                            string ApePat = reader.GetString(1);
                            string ApeMat = reader.GetString(2);
                            string Nomcalle = reader.GetString(3);
                            int Numcasa = reader.GetInt32(4);
                            string Municipiocl = reader.GetString(5);
                            string CodPos = reader.GetString(6);
                            string Ciudad = reader.GetString(7);
                            string Estado = reader.GetString(8);
                            string País = reader.GetString(9);
                            string RFC = reader.GetString(10);
                            DateTime fechaNacimiento = reader.GetDateTime(11);
                            string Estadocivil = reader.GetString(12);
                            string Referencia = reader.GetString(13);
                            string telefonoCasa = reader.GetString(14);
                            string telefonoCelular = reader.GetString(15);
                            string correo = reader.GetString(16);

                            txtbx_nombrecliente.Text = Nombre;
                            txtbx_apellidopcliente.Text = ApePat;
                            txtbx_apellidomcliente.Text = ApeMat;
                            dttm_fechanacimientocliente.Value = fechaNacimiento;
                            txtbx_rfccliente.Text = RFC;
                            txtbx_estadocivilcliente.Text = Estadocivil;
                            txtbx_nombrecallecliente.Text = Nomcalle;
                            txtbx_numcasacliente.Text = Numcasa.ToString();
                            txtbx_municipiocliente.Text = Municipiocl;
                            txtbx_codigopostalcliente.Text = CodPos;
                            txtbx_ciudadcliente.Text = Ciudad;
                            txtbx_estadocliente.Text = Estado;
                            txtbx_paiscliente.Text = País;
                            txtbx_correocliente.Text = correo;
                            txtbx_telcasacliente.Text = telefonoCasa;
                            txtbx_telcelcliente.Text = telefonoCelular;
                            Referenciahotel.Text = Referencia;

                        }
                    }
                }
            }

            conexion.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Open();

            if (!string.IsNullOrEmpty(txtbx_idop.Text))
            {

                // Create the SqlCommand object with the stored procedure name
                using (SqlCommand comando1 = new SqlCommand("GetClienteByEmail", conexion))
                {
                    comando1.CommandType = CommandType.StoredProcedure;

                    // Add the ID_Operativo parameter to the command
                    comando1.Parameters.AddWithValue("@Correo", txtbx_idop.Text);


                    // Execute the command and retrieve the result set
                    using (SqlDataReader reader = comando1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the returned data and assign it to variables
                            string Nombre = reader.GetString(0);
                            string ApePat = reader.GetString(1);
                            string ApeMat = reader.GetString(2);
                            string Nomcalle = reader.GetString(3);
                            int Numcasa = reader.GetInt32(4);
                            string Municipiocl = reader.GetString(5);
                            string CodPos = reader.GetString(6);
                            string Ciudad = reader.GetString(7);
                            string Estado = reader.GetString(8);
                            string País = reader.GetString(9);
                            string RFC = reader.GetString(10);
                            DateTime fechaNacimiento = reader.GetDateTime(11);
                            string Estadocivil = reader.GetString(12);
                            string Referencia = reader.GetString(13);
                            string telefonoCasa = reader.GetString(14);
                            string telefonoCelular = reader.GetString(15);
                            string correo = reader.GetString(16);

                            txtbx_nombrecliente.Text = Nombre;
                            txtbx_apellidopcliente.Text = ApePat;
                            txtbx_apellidomcliente.Text = ApeMat;
                            dttm_fechanacimientocliente.Value = fechaNacimiento;
                            txtbx_rfccliente.Text = RFC;
                            txtbx_estadocivilcliente.Text = Estadocivil;
                            txtbx_nombrecallecliente.Text = Nomcalle;
                            txtbx_numcasacliente.Text = Numcasa.ToString();
                            txtbx_municipiocliente.Text = Municipiocl;
                            txtbx_codigopostalcliente.Text = CodPos;
                            txtbx_ciudadcliente.Text = Ciudad;
                            txtbx_estadocliente.Text = Estado;
                            txtbx_paiscliente.Text = País;
                            txtbx_correocliente.Text = correo;
                            txtbx_telcasacliente.Text = telefonoCasa;
                            txtbx_telcelcliente.Text = telefonoCelular;
                            Referenciahotel.Text = Referencia;
                            correocliente = correo;

                        }
                    }
                }
            }

            conexion.Close();
        }
    }
}
