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
    public partial class FormEmpleados : Form
    {
        CN_Empleado oEmpleado = new CN_Empleado();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            oEmpleado.listar(dtGridEmpleados);
        }
    }
}
