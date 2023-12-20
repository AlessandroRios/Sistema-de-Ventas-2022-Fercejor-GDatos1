using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Controlador
{
    public class CN_Empleado : IMantenedor
    {
        public CN_Empleado()
        {
        }
        public void crear()
        {

        }
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void listar(DataGridView tabla)
        {
            using (DBSVFercejorEntities db = new DBSVFercejorEntities())
            {
                tabla.DataSource = db.VistaEmpleados.ToList();
            }
        }
    }
}

