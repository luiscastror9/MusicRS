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
    
    public partial class Carac_sala
    {
        public int Id { get; set; }
        public int Id_Sala { get; set; }
        public int Id_Caracteristicas { get; set; }
    
        public virtual Caracteristicas Caracteristicas { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
