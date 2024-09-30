using System.ComponentModel.DataAnnotations;

namespace GeremyDelosSantos_Ap1_P1.Models;

public class Prestamos
{
    [Key]
    public string PrestamosId { get; set; }
    [Required]
    public string Nombre { get; set; }
}
