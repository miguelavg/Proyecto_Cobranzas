//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecaudaSoft.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parametro
    {
        public int idParametro { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
        public Nullable<decimal> valorNum { get; set; }
        public Nullable<int> idPadre { get; set; }
        public string codUnico { get; set; }
    }
}
