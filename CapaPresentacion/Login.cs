using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbingresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            //expresion landa tomar accion con respecto a la lista 
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtcarnet.Text && u.Clave == txtclave.Text).FirstOrDefault();

            if(ousuario != null)
            {

                Inicio form = new Inicio(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        //se encarga de mostrar nuestro formulario de log que se oculta
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            //limpiar carnet y clave
            txtcarnet.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
