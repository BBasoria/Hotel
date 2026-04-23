using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MADProyectoEneJun2023.Resources;
using System.Configuration;

namespace MADProyectoEneJun2023
{
    
    public partial class CheckOut : Form
    {
        private string correoactual;
        public CheckOut(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }

        //SqlConnection conexion = new SqlConnection("server=DESKTOP-TDJT3CO;database=master;integrated security=true;MultipleActiveResultSets=True");
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);


        private void CheckOut_Load(object sender, EventArgs e)
        {
            cbbx_tipodepagoreserv.Items.Add("Credito"); //Para agregar datos a un combobox
            cbbx_tipodepagoreserv.Items.Add("Debito");
            cbbx_tipodepagoreserv.Items.Add("Transferencia");
        }

        private void ACEPTAR_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (!string.IsNullOrEmpty(GUID.Text))
            {



                Guid guidValue = new Guid(GUID.Text);
                SqlParameter guidParam = new SqlParameter("@Cod", SqlDbType.UniqueIdentifier);
                guidParam.Value = guidValue;



                SqlCommand GUIDfinder = new SqlCommand("CheckOut", conexion);
                GUIDfinder.CommandType = CommandType.StoredProcedure;
                GUIDfinder.Parameters.Add(guidParam);
                GUIDfinder.Parameters.AddWithValue("@Tipo", cbbx_tipodepagoreserv.Text);
                int bit;



                if (checkBox1.Checked)
                {
                    bit = 1;
                }
                else
                {
                    bit = 0;
                }
                GUIDfinder.Parameters.AddWithValue("@Servicios", bit);



                using (SqlDataReader reader = GUIDfinder.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Select  C.Nombre_cliente,R.Número_habitación_reservación , R.Fecha_salida_reservación
                            Guid GUIDS = reader.GetGuid(0);
                            int Numhab = reader.GetInt32(1);
                            string Nombrecl = reader.GetString(2);
                            string Hotelnombre = reader.GetString(3);



                            DateTime Fechaentrada = reader.GetDateTime(4);
                            DateTime Fechasalida = reader.GetDateTime(5);
                            string Tipo = reader.GetString(6);
                            int Rango = reader.GetInt32(7);
                            decimal Dinerofalt = reader.GetDecimal(8);
                            decimal Anticipo = reader.GetDecimal(9);
                            decimal Montototal = reader.GetDecimal(10);
                            int numpers = reader.GetByte(11);
                            DateTime FechaCreación = reader.GetDateTime(12);
                            string servicioshotel = reader.GetString(13);



                            // Generate a new GUID
                            Guid newGuid = Guid.NewGuid();



                            // Convert the GUID to a string
                            string guidString = newGuid.ToString();




                            if (checkBox1.Checked)
                            {
                                Montototal += 500;
                                MessageBox.Show("Código de Reservación: " + GUIDS.ToString() +
                              "\r\nNúmero de Habitación:" + Numhab.ToString() +
                              "\r\nNombre del Cliente:" + Nombrecl +
                              "\r\nNúmero de personas hospedadas:" + numpers.ToString() +
                              "\r\nNomrbre del hotel hospedado:" + Hotelnombre.ToString() +
                              "\r\nFecha de CheckIn:" + Fechaentrada.ToString() +
                              "\r\nFecha de CheckOut:" + Fechasalida.ToString() +
                              "\r\nTipo de pago elegido:" + Tipo +
                              "\r\nRango de fechas hospedadas:" + Rango.ToString() +
                              "\r\nAnticipo dado:" + Anticipo.ToString() +
                              "\r\nMonto total, con servicios adicionales añadidos:" + Montototal.ToString());



                            }
                            else
                            {
                                MessageBox.Show("Código de Reservación: " + GUIDS.ToString() +
                              "\r\nNúmero de Habitación:" + Numhab.ToString() +
                              "\r\nNombre del Cliente:" + Nombrecl +
                              "\r\nNúmero de personas hospedadas:" + numpers.ToString() +
                              "\r\nNomrbre del hotel hospedado:" + Hotelnombre.ToString() +
                              "\r\nFecha de CheckIn:" + Fechaentrada.ToString() +
                              "\r\nFecha de CheckOut:" + Fechasalida.ToString() +
                              "\r\nTipo de pago elegido:" + Tipo +
                              "\r\nRango de fechas hospedadas:" + Rango.ToString() +
                              "\r\nAnticipo dado:" + Anticipo.ToString() +
                              "\r\nMonto total:" + Montototal.ToString());
                            }



                            //Generar factura archivo de texto
                            string nombreArchivo = "factura_" + GUIDS + ".txt"; // Nombre del archivo de factura
                            using (StreamWriter sw = new StreamWriter(nombreArchivo))
                            {
                                sw.WriteLine("***** FACTURA *****");
                                sw.WriteLine("Código de Factura: " + guidString);
                                sw.WriteLine("Código de Reservación: " + GUIDS);
                                sw.WriteLine("Número de Habitación: " + Numhab);
                                sw.WriteLine("Nombre del Cliente: " + Nombrecl);
                                sw.WriteLine("Número de Personas en la Habitación: " + numpers.ToString());
                                sw.WriteLine("Nombre del hotel hospedado: " + Hotelnombre.ToString());
                                sw.WriteLine("Creación de la Reservación: " + FechaCreación);
                                sw.WriteLine("Fecha de Entrada: " + Fechaentrada.ToString());
                                sw.WriteLine("Fecha de Salida: " + Fechasalida.ToString());
                                sw.WriteLine("Tipo de Pago: " + Tipo);
                                sw.WriteLine("Rango de Fechas: " + Rango.ToString());
                                sw.WriteLine("Anticipo de Reservación: " + Anticipo.ToString());
                                sw.WriteLine("Monto Total: " + Montototal.ToString());
                                sw.WriteLine("Servicios usados: " + servicioshotel);



                            }



                            MessageBox.Show("Archivo de factura generado exitosamente.", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        MessageBox.Show("Fecha de salida actualizada");
                        GUID.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Código no encontrado");
                        GUID.Text = string.Empty;
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
