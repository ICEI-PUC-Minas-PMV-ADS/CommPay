using System;
using Commpay.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}