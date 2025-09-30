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

    public DateTime Fecha { get; set; } 

    [Required(ErrorMessage ="Este campo no puede estar vacio")]

    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Este campo no puede estar vacio")]

    public double Precio { get; set; }

   



}