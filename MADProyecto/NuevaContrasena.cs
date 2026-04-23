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
    public partial class NuevaContrasena : Form
    {
        private EntradaUsuario.datocorreo entradaUsuario;
        public NuevaContrasena(EntradaUsuario.datocorreo entradaUsuario)
        {
            InitializeComponent();
            this.entradaUsuario = entradaUsuario;
        }
        //Si estamos en otra computadora, se cambia el server con el nombre de la laptop donde se trabajará y el database con el nombre de la base
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void NuevaContrasena_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            string Dato = entradaUsuario.GetCorreoIniciador();//CORREO DEL USUARIO ACTUAL
            conexion.Open();
            if (txtbx_contranueva.Text != "")
            {
                //Verifica que la constraseña sea la misma en los dos campos
                if (txtbx_contranueva.Text == txtbx_repetircontra.Text)
                {

                    if (txtbx_contranueva.Text.Length < 8)//tengo el largo de la contraseña la tengo separada
                    {
                        MessageBox.Show("La contraseña tiene que ser al menos 8 carácteres");
                    }
                    else
                    {
                        EntradaUsuario prueba = new EntradaUsuario();
                        bool result = prueba.ContraseñaValidar(txtbx_contranueva.Text);
                        //validar los requerimientos de la contraseña
                        if (result == true)
                        {
                            SqlCommand comand = new SqlCommand("NC_Recuperar", conexion);
                            comand.CommandType = CommandType.StoredProcedure;
                            comand.Parameters.AddWithValue("@Correo", Dato);
                            SqlDataReader lectora;
                            lectora = comand.ExecuteReader();

                            //Cuenta las filas que tuvo el query
                            if (lectora.FieldCount > 2)
                            {
                                //Que se hace si hay más de dos
                                //eliminamos las 2
                                MessageBox.Show("Hay más de dos registros de contraseñas para este usuario, error en la base de datos");
                                lectora.Close();
                                return;
                            }
                            else
                            {
                                lectora.Close();
                                SqlCommand comandoContraseñanueva = new SqlCommand("NC_Validación", conexion);
                                comandoContraseñanueva.CommandType = CommandType.StoredProcedure;
                                comandoContraseñanueva.Parameters.AddWithValue("@Correo", Dato);
                                comandoContraseñanueva.Parameters.AddWithValue("@NuevaContraseña", txtbx_contranueva.Text);
                                SqlDataReader lector2;
                                lector2 = comandoContraseñanueva.ExecuteReader();
                                if (lector2.HasRows)
                                {
                                    MessageBox.Show("La contraseña propuesta no está disponible, requiere una contraseña nueva");
                                    txtbx_contranueva.Text = string.Empty;
                                    txtbx_repetircontra.Text = string.Empty;
                                    lector2.Close();
                                }
                                else
                                {
                                    SqlCommand comandoInsertar = new SqlCommand("UpdatePasswordAndInsertHistorical", conexion);
                                    comandoInsertar.CommandType = CommandType.StoredProcedure;
                                    comandoInsertar.Parameters.AddWithValue("@Correo_electrónico", Dato);
                                    comandoInsertar.Parameters.AddWithValue("@NewPassword", txtbx_contranueva.Text);
                                    SqlDataReader lector3;
                                    lector3 = comandoInsertar.ExecuteReader();

                                    MenuOperativo AbrirmenuOperativo = new MenuOperativo(Dato);
                                    this.Hide();
                                    AbrirmenuOperativo.ShowDialog();

                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("La contraseña tiene que tener al menos una letra mayúscula, una minúscula, ser de almenos 8 carácteres y tener un carácter especial");
                            txtbx_contranueva.Text = string.Empty;
                            txtbx_repetircontra.Text = string.Empty;
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Repita la misma contraseña en ambos campos.");
                }

            }
            else
            {
                MessageBox.Show("Escriba una contraseña nueva");
            }
            conexion.Close();
        }
    }
}
