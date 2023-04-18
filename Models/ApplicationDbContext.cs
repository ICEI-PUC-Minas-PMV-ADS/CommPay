using System;
using Commpay.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //Criação da tabela.
    public DbSet <Usuario> Usuarios { get; set; }
}