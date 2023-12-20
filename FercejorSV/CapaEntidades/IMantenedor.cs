using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidades
{
    public interface IMantenedor
    {
        void crear();
        void eliminar();
        void actualizar();
        void listar(DataGridView tabla);
    }
}
