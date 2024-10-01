using GeremyDelosSantos_Ap1_P1.Models;
using GeremyDelosSantos_Ap1_P1.DAL;
using Microsoft.EntityFrameworkCore;

namespace GeremyDelosSantos_Ap1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options): base(options) { }

    public DbSet<Prestamos> Prestamos { get; set; }
}
