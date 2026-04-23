using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace MADProyectoEneJun2023
{
    public partial class CheckIn : Form
    {
        private string correoactual;
        public CheckIn(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }
        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void ACEPTAR_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (!string.IsNullOrEmpty(GUID.Text))
            {

                Guid guidValue = new Guid(GUID.Text);
                SqlParameter guidParam = new SqlParameter("@Cod", SqlDbType.UniqueIdentifier);
                guidParam.Value = guidValue;

                SqlCommand GUIDfinder = new SqlCommand("CheckIn", conexion);
                GUIDfinder.CommandType = CommandType.StoredProcedure;
                GUIDfinder.Parameters.Add(guidParam);

                using (SqlDataReader reader = GUIDfinder.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
                            string Nombrecl = reader.GetString(0);
                            int Numhab = reader.GetInt32(1);
                            DateTime Fechasalida = reader.GetDateTime(2);

                            MessageBox.Show("Nombre de cliente: " + Nombrecl +
                                "\r\nNúmero de habitación: " + Numhab.ToString() +
                                "\r\nFecha esperada de salida: " + Fechasalida.ToString());

                            MessageBox.Show("Fecha de entrada actualizada");
                        }
                        GUID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Código no encontrado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Proporcione el código de reservación");
            }

            conexion.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correoactual);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
        }
    }
}
