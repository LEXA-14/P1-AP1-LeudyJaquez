using Microsoft.EntityFrameworkCore;
using P1_AP1_LeudyJaquez.Model;
using P1_AP1_LeudyJaquez.DAL;
using System.Linq;
using System.Linq.Expressions;
using P1_AP1_LeudyJaquez.Components;

namespace P1_AP1_LeudyJaquez.Services;

public class RegistroServices(IDbContextFactory<Contexto> dbFactory)
{

    public async Task<List<EntradaHuacales>> GetLista(Expression<Func<EntradaHuacales,bool>>criterio)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        return await contexto.Registro.Where(criterio).ToListAsync();
        
    }

}

