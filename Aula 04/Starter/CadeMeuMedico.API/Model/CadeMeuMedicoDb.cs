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

        private DbSet<Usuario> Usuarios { get; set; }
    }
}
