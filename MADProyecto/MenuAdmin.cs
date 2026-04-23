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

namespace MADProyectoEneJun2023.Resources
{
    public partial class MenuAdmin : Form
    {

        private EntradaUsuario.datocorreo entradaUsuario;
        private string correoactual;
       
        public MenuAdmin(EntradaUsuario.datocorreo entradaUsuario)
        {
            InitializeComponent();
            this.entradaUsuario = entradaUsuario;
            this.correoactual = entradaUsuario.ToString();
        }
        public MenuAdmin(string correoactual)
        {
            InitializeComponent();
            this.correoactual = correoactual;
        }



        private void btn_tipodehabitacion_Click(object sender, EventArgs e)
        {
                Form_Habitacion ir8 = new Form_Habitacion(correoactual);
                this.Hide();
                ir8.Show();

        }

        private void btn_registrarhotel_Click(object sender, EventArgs e)
        {
                Form_Registrohotel ir8 = new Form_Registrohotel(correoactual);
                this.Hide();
                ir8.Show();
        }

        private void btn_registraroperativo_Click(object sender, EventArgs e)
        {
            Form_Registrooperativo ir = new Form_Registrooperativo(correoactual);
            this.Hide();
            ir.Show();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_habitacion_Click(object sender, EventArgs e)
        {
            Habitacion ir = new Habitacion(correoactual);
            this.Hide();
            ir.Show();

        }

        private void btn_reportesistema_Click_1(object sender, EventArgs e)
        {
            Reporteocupacion ir = new Reporteocupacion(correoactual);
            this.Hide();
            ir.Show();
        }

        private void btn_cancelareserv_Click_1(object sender, EventArgs e)
        {
            CancelarReservación ir = new CancelarReservación(correoactual);
            this.Hide();
            ir.Show();
        }

        private void btn_reporteventas_Click(object sender, EventArgs e)
        {
            Reporteventas ir = new Reporteventas(correoactual);
            this.Hide();
            ir.Show();
        }

        private void MenuAdmin_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
