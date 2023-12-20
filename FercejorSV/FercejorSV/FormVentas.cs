using CapaDatos;
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
    public partial class FormVentas : Form
    {
        CN_Venta oVenta = new CN_Venta();
        public FormVentas()
        {
            InitializeComponent();
        }

        private void ibtnVender_Click(object sender, EventArgs e)
        {
            
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            oVenta.listar(dtGridDatosVenta);

        }
    }
}
