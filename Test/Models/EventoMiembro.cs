//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventoMiembro
    {
        public int idEM { get; set; }
        public int evento { get; set; }
        public string miembro { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int usuario { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual Evento Evento1 { get; set; }
        public virtual Miembro Miembro1 { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}