//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_VENTA
    {
        public int idDetalleVenta { get; set; }
        public Nullable<int> idVenta { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public decimal subTotal { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
    
        public virtual PRODUCTOS PRODUCTOS { get; set; }
        public virtual VENTAS VENTAS { get; set; }
    }
}