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
    
    public partial class GestorXGestor
    {
        public int idGestorXGestor { get; set; }
        public int idGestorSupervisor { get; set; }
        public int idGestorSupervisado { get; set; }
    
        public virtual Gestor Gestor { get; set; }
        public virtual Gestor Gestor1 { get; set; }
    }
}
