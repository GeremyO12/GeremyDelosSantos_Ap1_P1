using System.ComponentModel.DataAnnotations;

namespace GeremyDelosSantos_Ap1_P1.Models;

public class Registro
{
    [Key]
    public string RegistroId { get; set; }
    [Required]
    public string Nombre { get; set; }
}
