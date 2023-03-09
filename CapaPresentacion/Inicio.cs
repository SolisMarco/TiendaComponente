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
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        //variable para indicar que menu esta activo
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;


        //constructor del formulario de inicio
        public Inicio(Usuario objusuario)
        {

            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //visualizar el tipo de permiso
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            //recorer cada menu para validar los permisos del usuario 
            foreach(IconMenuItem iconmenu in Menu.Items)
            {
                //usando expresion landa
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if(encontrado == false)
                {
                   iconmenu.Visible = false;
                }
            }

            lblusuario.Text = usuarioActual.NombreCompleto;
        }
        //metodo para mostrar formulario usuario
        private void AbrirFormulario(IconMenuItem menu, Form formulario) {

            if (MenuActivo != null)
            {
                //para cuando se selecione un menu quede en blanco
                MenuActivo.BackColor = Color.White;
            }
            //menu seleccionado quedara marcado de un color difente
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            //formato para mostrar formulario en el contenedor
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkViolet;

            //agregando formulario al contenedor
            contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());

        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarsalida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menusalida, new frmSalida());
        }

        private void submenuverdetallesalida_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menusalida, new frmDetalleSalida());
        }

        private void submenuregistrarentrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuentradas, new frmEntrada());
        }

        private void submenuverdetalleentrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuentradas, new frmDetalleEntrada());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedor_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }
    }
}
