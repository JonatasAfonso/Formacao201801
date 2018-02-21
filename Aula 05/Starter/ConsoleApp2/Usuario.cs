using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Table("usuarios")]
   public class Usuario
    {
        public string Nome { get; set; }
    }
}
