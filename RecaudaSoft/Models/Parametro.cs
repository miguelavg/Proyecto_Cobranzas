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
        public Parametro()
        {
            this.Acreedors = new HashSet<Acreedor>();
            this.Actividads = new HashSet<Actividad>();
            this.Carteras = new HashSet<Cartera>();
            this.Deudas = new HashSet<Deuda>();
            this.Deudors = new HashSet<Deudor>();
            this.Deudors1 = new HashSet<Deudor>();
            this.Deudors2 = new HashSet<Deudor>();
            this.Gestors = new HashSet<Gestor>();
            this.Gestors1 = new HashSet<Gestor>();
            this.Gestors2 = new HashSet<Gestor>();
            this.Refinanciacions = new HashSet<Refinanciacion>();
            this.Deudas1 = new HashSet<Deuda>();
        }
    
        public int idParametro { get; set; }
        public string tipo { get; set; }
        public string valor { get; set; }
        public Nullable<decimal> valorNum { get; set; }
        public Nullable<int> idPadre { get; set; }
        public string codUnico { get; set; }
    
        public virtual ICollection<Acreedor> Acreedors { get; set; }
        public virtual ICollection<Actividad> Actividads { get; set; }
        public virtual ICollection<Cartera> Carteras { get; set; }
        public virtual ICollection<Deuda> Deudas { get; set; }
        public virtual ICollection<Deudor> Deudors { get; set; }
        public virtual ICollection<Deudor> Deudors1 { get; set; }
        public virtual ICollection<Deudor> Deudors2 { get; set; }
        public virtual ICollection<Gestor> Gestors { get; set; }
        public virtual ICollection<Gestor> Gestors1 { get; set; }
        public virtual ICollection<Gestor> Gestors2 { get; set; }
        public virtual ICollection<Refinanciacion> Refinanciacions { get; set; }
        public virtual ICollection<Deuda> Deudas1 { get; set; }
    }
}
