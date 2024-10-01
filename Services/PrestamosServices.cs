using GeremyDelosSantos_Ap1_P1.DAL;
using GeremyDelosSantos_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GeremyDelosSantos_Ap1_P1.Services;

public class PrestamosServices
{
    //Guardar
    //Existe
    //Insertar
    //Modificar
    //Listar
    //Buscar
    //Eliminar

    private readonly Contexto _context;

    public PrestamosServices(Contexto contexto)
    {
        _context = contexto;
    }

    public async Task<bool> Existe(int prestamosId)
    {
        return await _context.Prestamos
            .AnyAsync(p => p.PrestamosId == prestamosId);
    }

    private async Task<bool> Insertar(Prestamos prestamos)
    {

        _context.Prestamos.Add(prestamos);
        return await _context.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(Prestamos prestamos)
    {
        _context.Update(prestamos);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(Prestamos prestamos)
    {
        if (await ExisteNombre(prestamos.Deudor, prestamos.PrestamosId))
        {
            return false;
        }
        if (!await Existe(prestamos.PrestamosId))
            return await Insertar(prestamos);
        else
        {
            return await Modificar(prestamos);
        }
    }

    public async Task<bool> Eliminar(int id)
    {
        var prioridades = await _context.Prestamos
            .Where(p => p.PrestamosId == id)
            .ExecuteDeleteAsync();
        return prioridades > 0;
    }

    public async Task<Prestamos?> Buscar(int id)
    {
        return await _context.Prestamos
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.PrestamosId == id);
    }

    public List<Prestamos> Listar(Expression<Func<Prestamos, bool>> criterio)
    {
        return _context.Prestamos
            .Include(t => t.PrestamosId)
            .AsNoTracking()
            .Where(criterio)
            .ToList();
    }
    public async Task<bool> ExisteNombre(string deudor, int? prestamosId = null)
    {
        if (prestamosId.HasValue)
        {
            return await _context.Prestamos.AnyAsync(t => t.Deudor == deudor && t.PrestamosId != prestamosId);
        }
        else
        {
            return await _context.Prestamos.AnyAsync(t => t.Deudor == deudor);
        }
    }
}
