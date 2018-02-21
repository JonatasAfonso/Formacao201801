using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadeMeuMedico.API.Model;
using Microsoft.EntityFrameworkCore;

namespace CadeMeuMedico.API
{
    public class CadeMeuMedicoDb : DbContext
    {
        public CadeMeuMedicoDb(DbContextOptions<CadeMeuMedicoDb> options): base(options)
        { }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }

    }
}
