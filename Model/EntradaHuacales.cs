using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace P1_AP1_LeudyJaquez.Model;

public class EntradaHuacales
{
    [Key]
    public int IdEntrada { get; set; }

    
    [Required(ErrorMessage = "Este campo no puede estar vacio")]

    public string NombreCliente { get; set; }

    [Required(ErrorMessage = "Este campo no puede estar vacio")]

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage ="Este campo no puede estar vacio")]

    [Range(0, int.MaxValue, ErrorMessage = "La Cantidad no puede ser negativa")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Este campo no puede estar vacio")]

    [Range(0,int.MaxValue,ErrorMessage ="El Precio no puede ser negativo")]
    public double Precio { get; set; }

    public double Importe => Cantidad * Precio;



}