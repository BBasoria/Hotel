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
    public partial class Form_Iniciosesion : Form
    {
        public Form_Iniciosesion()
        {
            InitializeComponent();
        }
        //MultipleActiveResultSets=True
        //Es lo que nos permite usar varios querys en una sola sesión

        //Si estamos en otra computadora, se cambia el server con el nombre de la laptop donde se trabajará y el database con el nombre de la base
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private int a = 0;
        private bool UsuarioA = false;
        private bool UsuarioO = false;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_iniciosesion_Click(object sender, EventArgs e)
        {
            //Se comprueba que opción se puso en el combobox, si Admin u Operativo. Se activa a true la opción que sea
            if (Equals(comboBox1.Text, "Administrador") == true)
            {
                UsuarioA = true;
                //MessageBox.Show("Se eligio Administrador");
            }
            if (Equals(comboBox1.Text, "Operativo") == true)
            {
                UsuarioO = true;
                // MessageBox.Show("Se eligio Operativo");
            }

            conexion.Open();

            //aquí hay que considerar la diferencia de lógica, primero definimos el cómo se va a lidiar con la barra de usuario y ya de acuerdo a eso cambia la lógica del select

            //la consulta va a buscar el usuario, si existe en la tabla de Usuario

            SqlCommand comando = new SqlCommand("UsuarioExistente", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
            comando.Parameters.AddWithValue("@Contraseña", txtbx_contrasena.Text);
            comando.Parameters.AddWithValue("@NuevaContraseña", txtbx_contrasena.Text);

            //SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            //si se encuentra un usuario con los datos, entonces pasa a checar si eligieron correctamente su rol
            if (lector.HasRows == true)
            {
                lector.Close();
                //Dependiendo el usuario se va a intentar mandar a distintas ventanas
                if (UsuarioA == true)
                {
                    //vamos a hacer una búsqueda en la base de datos para ver si es administrador
                    //string AdminUsuario = "Select Correo_electrónico from Administrador_ where Correo_electrónico = '" + txtbx_correo.Text+"'";
                    SqlCommand comandoAdmin = new SqlCommand("BusquedaAdministrador", conexion);
                    comandoAdmin.CommandType = CommandType.StoredProcedure;
                    comandoAdmin.Parameters.AddWithValue("@Correo", txtbx_correo.Text);

                    SqlDataReader lectorAdmin;
                    lectorAdmin = comandoAdmin.ExecuteReader();
                    if (lectorAdmin.HasRows == true)
                    {
                        EntradaUsuario.datocorreo intermidario = new EntradaUsuario.datocorreo();
                        intermidario.AsignarCorreo(txtbx_correo.Text);

                        //La ventana de Menu Admin
                        MenuAdmin AbrirMenuAdmin = new MenuAdmin(txtbx_correo.Text);
                        this.Hide();
                        AbrirMenuAdmin.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no es un administrador");
                        comboBox1.Text = string.Empty;
                    }

                }
                if (UsuarioO == true)
                {
                    SqlCommand comandoOpera = new SqlCommand("ValidoOperativo", conexion);
                    comandoOpera.CommandType = CommandType.StoredProcedure;
                    comandoOpera.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
                    SqlDataReader lectorOpera;
                    lectorOpera = comandoOpera.ExecuteReader();

                    if (lectorOpera.HasRows == true)
                    {
                        lectorOpera.Close();
                        //checar que no sea un Operativo que fue recientemente Habilitado, el prom checa si el correo y la contraseña coiciden, al igual que la columno NUevaContraseña esté en deafult
                        SqlCommand comandoOperaNueContra = new SqlCommand("SiesHabilitadoOperativo", conexion);
                        comandoOperaNueContra.CommandType = CommandType.StoredProcedure;
                        comandoOperaNueContra.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
                        comandoOperaNueContra.Parameters.AddWithValue("@Contraseña", txtbx_contrasena.Text);
                        SqlDataReader lectorOperaNueContra;
                        lectorOperaNueContra = comandoOperaNueContra.ExecuteReader();


                        if (lectorOperaNueContra.HasRows == true)
                        {

                            /* Form_Registrocliente AbrirRegClientes = new Form_Registrocliente();
                             this.Hide();
                             AbrirRegClientes.ShowDialog();*/
                            EntradaUsuario.datocorreo intermidario = new EntradaUsuario.datocorreo();
                            intermidario.AsignarCorreo(txtbx_correo.Text);

                            //La ventana de MenuOperativo
                            MenuOperativo AbrirMenuOperativo = new MenuOperativo(txtbx_correo.Text);
                            this.Hide();
                            AbrirMenuOperativo.ShowDialog();

                        }
                        else
                        {

                            lectorOperaNueContra.Close();//se cierra el query anterior para poder generar otro

                            //la búsqueda masiva para poder encontrar el mismo correo en Operativo y Usuario que el que nos dan en la ventana al igual que la contraseña nueva
                            SqlCommand comandoOperaInhaNC = new SqlCommand("BusquedaOperativoYNuevaContraseña", conexion);
                            comandoOperaInhaNC.CommandType = CommandType.StoredProcedure;
                            comandoOperaInhaNC.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
                            comandoOperaInhaNC.Parameters.AddWithValue("@Contraseña", txtbx_contrasena.Text);
                            SqlDataReader lectorOperaInhaNC;
                            lectorOperaInhaNC = comandoOperaInhaNC.ExecuteReader();

                            if (lectorOperaInhaNC.HasRows == true)
                            {
                                EntradaUsuario.datocorreo intermidario = new EntradaUsuario.datocorreo();
                                intermidario.AsignarCorreo(txtbx_correo.Text);


                                //la ventana de NuevaContraseña
                                NuevaContrasena AbrirNuevaContraseña = new NuevaContrasena(intermidario);
                                this.Hide();
                                AbrirNuevaContraseña.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("El usuario fue Rehabilitado, debe de usar la contraseña nueva proporcionada por el Administrador");
                                txtbx_contrasena.Text = string.Empty;
                            }
                        }

                    }
                    else
                    {

                        SqlCommand comandoInha = new SqlCommand("ChequeoOperativo", conexion);
                        comandoInha.CommandType = CommandType.StoredProcedure;
                        comandoInha.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
                        SqlDataReader lectorInha;
                        lectorInha = comandoInha.ExecuteReader();
                        if (lectorInha.HasRows == true)
                        {
                            MessageBox.Show("El usuario es un operativo Inhabilitado. Pida a un Administrador que lo Habiliten, de nuevo");
                            txtbx_correo.Text = string.Empty; //para limpiar los campos de un textbox
                            txtbx_contrasena.Text = string.Empty;

                        }
                        else
                        {
                            MessageBox.Show("El usuario no es un operativo");
                            comboBox1.Text = string.Empty;
                        }


                    }

                }

            }
            //si no se encuentra un Usuario con los datos proporcionados
            else
            {
                MessageBox.Show("Introduzca los datos correctos");

                a++; //Va a estar creciendo cada vez que se pique Iniciar sesión pero no sea los datos correctos
                if (a >= 3)
                {
                    SqlCommand comandoInhabilitar = new SqlCommand("BusquedaOperativo", conexion);
                    comandoInhabilitar.CommandType = CommandType.StoredProcedure;
                    comandoInhabilitar.Parameters.AddWithValue("@Correo", txtbx_correo.Text);

                    SqlDataReader lectorInhabilitar;
                    lectorInhabilitar = comandoInhabilitar.ExecuteReader();

                    //Si es Operativo y se equivoca tres veces, se bloqueara el usuario. Osea, cambia su estado a Inactivo

                    if (lectorInhabilitar.HasRows == true)
                    {
                        //Mandar un comando sin que regrese nada, intentar cambiar el estado de un operativo a Inhabilitado
                        using (SqlCommand command = new SqlCommand("InhabilitarOperativoIS", conexion))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Correo", txtbx_correo.Text);
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Su usuario ha sido Inhabilitado");
                    }


                }
                txtbx_correo.Text = string.Empty; //para limpiar los campos de un textbox
                txtbx_contrasena.Text = string.Empty;
            }
            conexion.Close();

        }

        private void Form_Iniciosesion_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Administrador"); //Para agregar datos a un combobox
            comboBox1.Items.Add("Operativo");
            a = 1;
        }

        private void txtbx_correo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
