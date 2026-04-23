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
    public partial class CancelarReservación : Form
    {
        private string correoactual;
        public CancelarReservación(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }

        //SqlConnection conexion = new SqlConnection("server=LAPTOP-22O3NMO8;database=ProyectoEneJun2023;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuOperativo AbrirMenuOperativo = new MenuOperativo(correoactual);
            this.Hide();
            AbrirMenuOperativo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text)) {
                conexion.Open();
                Guid guidValue = new Guid(textBox1.Text);
                SqlParameter guidParam = new SqlParameter("@GUID", SqlDbType.UniqueIdentifier);
                guidParam.Value = guidValue;

                SqlCommand GUIDfinder = new SqlCommand("CancelarReservación", conexion);
                GUIDfinder.CommandType = CommandType.StoredProcedure;
                GUIDfinder.Parameters.Add(guidParam);

                using (SqlDataReader reader = GUIDfinder.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
                         
                            int exito = reader.GetInt32(0);
                            if (exito == 1)
                            {
                                MessageBox.Show("Se cancelo la reservación con exito");
                            } else if (exito == 0)
                            {
                                MessageBox.Show("No es posible hacer la cancelación");
                            }

                        }
                        textBox1.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Código no encontrado");
                    }
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingrese el código de Reservación");
            }
        }
    }
}
