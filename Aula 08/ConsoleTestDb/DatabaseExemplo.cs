using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestDb
{
   public class DatabaseExemplo : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
    }
}
