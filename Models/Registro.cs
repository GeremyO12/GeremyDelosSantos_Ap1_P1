using System.ComponentModel.DataAnnotations;

namespace GeremyDelosSantos_Ap1_P1.Models;

public class Registro
{
    [Key]
    public string Id { get; set; }
    [Required]
    public string Name { get; set; }
}
