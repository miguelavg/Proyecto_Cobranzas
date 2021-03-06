namespace RecaudaSoft.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(GestorMetaData))]
    public partial class Gestor {
        public bool Checked { get; set; }

        public string NombreCompleto
        {
            get
            {
                return nombres + " " + apellidoPaterno + " " + apellidoMaterno;
            }
            set{}
        }
    }

    public class GestorMetaData
    {
        [DisplayName("Id")]
        public int idGestor { get; set; }
        [DisplayName("Id Nivel Gestor")]
        public int idNivelGestor { get; set; }
        [DisplayName("Id Tipo Gestor")]
        public int idTipoGestor { get; set; }
        [DisplayName("Nombres")]
        public string nombres { get; set; }
        [DisplayName("Apellido paterno")]
        public string apellidoPaterno { get; set; }
        [DisplayName("Apellido materno")]
        public string apellidoMaterno { get; set; }
        [DisplayName("Fecha de ingreso")]
        public System.DateTime fechaIngreso { get; set; }
        [DisplayName("Deudas recuperadas")]
        public Nullable<int> deudasRecuperadas { get; set; }
        [DisplayName("Disponible")]
        public int disponible { get; set; }
        [DisplayName("Tipo de documento")]
        public int tipoDocumento { get; set; }
        [DisplayName("Número de documento")]
        public string numeroDocumento { get; set; }
        [DisplayName("Potencial")]
        public Nullable<decimal> potencial { get; set; }

        [DisplayName("Nivel")]
        public virtual Parametro Parametro { get; set; }
        [DisplayName("Tipo de documento")]
        public virtual Parametro Parametro1 { get; set; }
        [DisplayName("Tipo")]
        public virtual Parametro Parametro2 { get; set; }
        [DisplayName("Deudas asignadas")]
        public virtual ICollection<GestorXDeuda> GestorXDeudas { get; set; }
        [DisplayName("Jefe")]
        public virtual ICollection<GestorXGestor> GestorXGestors1 { get; set; }
        [DisplayName("Gestores asignados")]
        public virtual ICollection<GestorXGestor> GestorXGestors { get; set; }
        [DisplayName("Usuarios")]
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
