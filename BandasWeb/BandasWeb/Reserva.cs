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
    
    public partial class Reserva
    {
        public int Id { get; set; }
        public int Id_horario_sala { get; set; }
        public int Id_usuario { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Horario_sala Horario_sala { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
