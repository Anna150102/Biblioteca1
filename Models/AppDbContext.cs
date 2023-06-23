using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Autor> Autores {get;set;}
         public DbSet<Docente> Docentes {get;set;}
          public DbSet<Editorial> Editoriales {get;set;}
           public DbSet<Genero> Generos {get;set;}
            public DbSet<Libros> Libros {get;set;}
    }
}