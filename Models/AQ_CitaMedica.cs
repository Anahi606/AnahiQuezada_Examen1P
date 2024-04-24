using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnahiQuezada_Examen1P.Models
{
    public class AQ_CitaMedica
    {
        [Key]
        [ScaffoldColumn(false)]
        public int AQ_Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Se necesita saber el nombre del paciente")]
        [DisplayName("Nombre")]
        public string? AQ_Nombre { get; set; }
        [DisplayName("¿La cita es Urgente?")]
        public bool AQ_Urgente { get; set; }
        [Range(10.00, 200.00,
            ErrorMessage = "El precio debe ser de 10.00 a 200.00")]
        [DisplayName("Precio")]
        public decimal AQ_Precio { get; set; }
        [DisplayName("Fecha")]
        public DateTime AQ_Fecha { get; set; }
    }
}
