using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Contxto : DbContext
    {
        private DbSet<Usuario> usuarios { get; set; }
    }
}
