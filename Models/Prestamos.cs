using System.ComponentModel.DataAnnotations;

namespace GeremyDelosSantos_Ap1_P1.Models;

public class Prestamos
{
    [Key]
    [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser mayor o igual que 1.")]
    public int PrestamosId { get; set; }
    [Required(ErrorMessage = "El campo es obligatorio.")]
    public string Deudor { get; set; }
    [Required(ErrorMessage = "El campo es obligatorio.")]
    public string Concepto { get; set; }
    [Required(ErrorMessage = "El campo es obligatorio.")]
    public decimal Monto { get; set; }
}
