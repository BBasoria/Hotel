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

namespace MADProyectoEneJun2023
{
    public partial class MenuOperativo : Form
    {
        private EntradaUsuario.datocorreo entradaUsuario;
        private string correoactual;
       
        public MenuOperativo(EntradaUsuario.datocorreo entradaUsuario)
        {
            InitializeComponent();
            this.entradaUsuario = entradaUsuario;
            this.correoactual=entradaUsuario.ToString();

        }
        public MenuOperativo( string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }
        
        private void MenuOperativo_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrarcliente_Click(object sender, EventArgs e)
        {
            string Dato = entradaUsuario.GetCorreoIniciador();//CORREO DEL USUARIO ACTUAL


            //La ventana de Registro Cliente
            Form_Registrocliente form_Registrocliente = new Form_Registrocliente(correoactual);
            this.Hide();
            form_Registrocliente.ShowDialog();
            
        }

        private void btn_reservhotel_Click(object sender, EventArgs e)
        {
       
            From_Reservacion from_Reservacion = new From_Reservacion(correoactual);
            this.Hide();
            from_Reservacion.ShowDialog();
        }

        private void btn_facturas_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void btn_facturas_Click_1(object sender, EventArgs e)
        {
            Factura from_factura = new Factura(correoactual);
            this.Hide();
            from_factura.ShowDialog();
        }

        private void btn_reservhotel_Click_1(object sender, EventArgs e)
        {
            From_Reservacion ir8 = new From_Reservacion(correoactual);
            this.Hide();
            ir8.ShowDialog();
        }

        private void btn_checkin_Click_1(object sender, EventArgs e)
        {
            CheckIn ir8 = new CheckIn(correoactual);
            this.Hide();
            ir8.ShowDialog();
        }

        private void btn_registrarcliente_Click_1(object sender, EventArgs e)
        {
            Form_Registrocliente ir8 = new Form_Registrocliente(correoactual);
            this.Hide();
            ir8.ShowDialog();
            
        }

        private void btn_checkout_Click_1(object sender, EventArgs e)
        {
            CheckOut ir8 = new CheckOut(correoactual);
            this.Hide();
            ir8.ShowDialog();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HistorialCliente_Click(object sender, EventArgs e)
        {
            HistorialCliente ir8 = new HistorialCliente(correoactual);
            this.Hide();
            ir8.ShowDialog();
        }

        private void MenuOperativo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
/*
                EntradaUsuario.datocorreo intermidario = new EntradaUsuario.datocorreo();
                            intermidario.AsignarCorreo(txtbx_correo.Text);

                            //La ventana de MenuOperativo
                            MenuOperativo AbrirMenuOperativo = new MenuOperativo(intermidario);
                            this.Hide();
                            AbrirMenuOperativo.ShowDialog();
             */