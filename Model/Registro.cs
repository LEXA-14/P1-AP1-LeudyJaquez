using System.ComponentModel.DataAnnotations;

namespace P1_AP1_LeudyJaquez.Model;

    public class Registro
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="Este campo no puede estar vacio")]

    public string Nombres { get; set; }
}

