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
    
    public partial class PROVEEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDORES()
        {
            this.COMPRA = new HashSet<COMPRA>();
        }
    
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public string documento { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }
    }
}