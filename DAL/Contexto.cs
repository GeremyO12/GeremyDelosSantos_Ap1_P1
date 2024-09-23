﻿using GeremyDelosSantos_Ap1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace GeremyDelosSantos_Ap1_P1.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options): base(options) { }

    public DbSet<Registro> Registro { get; set; }
}
