using CapaNegocio.Controlador;
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
    public partial class FormProveedores : Form
    {
        CN_Proveedores oProveedor = new CN_Proveedores();
        
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            oProveedor.listar(dtGridEmpleados);
        }
    }
}
