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
    
    public partial class VENTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENTAS()
        {
            this.DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
            this.GUIA_RUTA = new HashSet<GUIA_RUTA>();
        }
    
        public int idVenta { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string tipoComprobante { get; set; }
        public Nullable<decimal> montoTotal { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GUIA_RUTA> GUIA_RUTA { get; set; }
        public virtual CLIENTES CLIENTES { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
