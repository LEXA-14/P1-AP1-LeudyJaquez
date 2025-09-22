using Microsoft.EntityFrameworkCore;
using P1_AP1_LeudyJaquez.DAL;
using P1_AP1_LeudyJaquez.Model;
using System.Linq;
using System.Linq.Expressions;

namespace P1_AP1_LeudyJaquez.Services;

    public class RegistroServices(IDbContextFactory<Contexto> dbFactory)
{

    public async Task<List<Registro>> GetLista(Expression<Func<Registro,bool>>criterio)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();

        return await contexto.Registro.Where(criterio).ToListAsync()
    }
}

