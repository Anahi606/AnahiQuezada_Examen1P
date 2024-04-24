using System.ComponentModel.DataAnnotations;

namespace AnahiQuezada_Examen1P.Models
{
    public class AQ_CitaMedica
    {
        public int AQ_Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? AQ_Nombre { get; set; }
        public bool AQ_Urgente { get; set; }
        [Range(10, 9999.99)]
        //[VerificarRango]
        public decimal AQ_Precio { get; set; }
    }
}

/*public class VerificarRango : Verificattion
    {

    }*/
