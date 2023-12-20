using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Controlador
{
    public class CN_Productos : IMantenedor
    {
        public void actualizar()
        {
            throw new NotImplementedException();
        }

        public void crear()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void listar(DataGridView tabla)
        {
            using(DBSVFercejorEntities db= new DBSVFercejorEntities())
            {
                tabla.DataSource = db.VistaProductos.ToList();
            }
        }
    }
}
