//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BandasWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Horario_sala
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Horario_sala()
        {
            this.Reserva = new HashSet<Reserva>();
        }
    
        public int Id { get; set; }
        public int Id_horario { get; set; }
        public int Id_sala { get; set; }
    
        public virtual Horario Horario { get; set; }
        public virtual Sala Sala { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
