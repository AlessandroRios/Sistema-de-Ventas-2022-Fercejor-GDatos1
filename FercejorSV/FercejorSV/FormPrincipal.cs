using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FercejorSV
{
    public partial class FormPrincipal : Form
    {
        public static Form formularioActivo = null;
        Formulario oFormulario = new Formulario();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuVenta_Click(object sender, EventArgs e)
        {
            oFormulario.mostrarFormulario(new FormVentas(), contenedor);
        }

        private void menuPedidos_Click(object sender, EventArgs e)
        {
            oFormulario.mostrarFormulario(new FormProveedores(), contenedor);
        }

        private void menuInventario_Click(object sender, EventArgs e)
        {
            oFormulario.mostrarFormulario(new FormInventario(), contenedor);
        }

        private void menuEmpleados_Click(object sender, EventArgs e)
        {
            oFormulario.mostrarFormulario(new FormEmpleados(), contenedor);
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            oFormulario.mostrarFormulario(new FormReportes(), contenedor);
        }

        private void MenuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
