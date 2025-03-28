
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace AgendaElectronica.Domain.Entities
{
    public class Contacts
    {
        [Key]
        int id { get; set; }
        [Column("Nombre")]
        string name { get; set; }
        [Column("Telefono")]
        string phoneNumber { get; set; }
        [Column("Correo")]
        string eMail { get; set; }
        [Column("Direccion")]
        string address { get; set; }
        [Column("FechaRegistro")]
        public DateTime insertDate { get; set; }
    }
}
