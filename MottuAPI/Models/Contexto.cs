using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MottuAPI.Models
{
    public class ApplicationDbContext : DbContext {

    public DbSet<Aluno> Alunos { get; set; } 

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}
}