//------------------------------------------------------------------------------
// <auto-generated>
//    Este c�digo se gener� a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicaci�n.
//    Los cambios manuales en este archivo se sobrescribir�n si se regenera el c�digo.
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