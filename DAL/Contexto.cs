using P1_AP1_LeudyJaquez.Model;
using Microsoft.EntityFrameworkCore;

namespace P1_AP1_LeudyJaquez.DAL;

public class Contexto: DbContext
{
    public Contexto(DbContextOptions options) : base(options)
    { }

    public DbSet<Contexto> Registro { get; set; }

    //registro is a nameplaceholder

   
}
