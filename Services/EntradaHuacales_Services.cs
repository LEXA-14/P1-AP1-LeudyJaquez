using Microsoft.EntityFrameworkCore;
using P1_AP1_LeudyJaquez.Model;
using P1_AP1_LeudyJaquez.DAL;
using System.Linq;
using System.Linq.Expressions;
using P1_AP1_LeudyJaquez.Components;

namespace P1_AP1_LeudyJaquez.Services;

public class EntradaHuacales_Services(IDbContextFactory<Contexto> dbFactory)
{

    //registrar
    //existe
    //buscar Id

    public async Task<bool>Guardar(EntradaHuacales entradaHuacales)
    {
        if(! await Existe(entradaHuacales.IdEntrada))
        {
            return await Insertar(entradaHuacales);

        }
        else
        {
            return await Modificar(entradaHuacales);
        }
    }

    private async Task<bool>Existe(int IdEntradaHuacal)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        return await contexto.EntradaHuacales.AnyAsync(e=>e.IdEntrada==IdEntradaHuacal);
    }

    private async Task<bool> Insertar(EntradaHuacales huacales)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        contexto.Add(huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool>Modificar (EntradaHuacales huacales)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        contexto.Update(huacales);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool>Eliminar(int id)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        return await contexto.EntradaHuacales.Where(e => e.IdEntrada == id).ExecuteDeleteAsync() > 0;
    }

    public async Task<EntradaHuacales>BuscarId(int idEntradaHuacales)
    {
        await using var contexto=await dbFactory.CreateDbContextAsync();
        return await contexto.EntradaHuacales.FirstOrDefaultAsync(e => e.IdEntrada == idEntradaHuacales);
    }

    public async Task<List<EntradaHuacales>> GetLista(Expression<Func<EntradaHuacales,bool>>criterio)
    {
        await using var contexto = await dbFactory.CreateDbContextAsync();
        return await contexto.EntradaHuacales.Where(criterio).ToListAsync();
        
    }

}

