using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MetadataType(typeof(Cidade))]
    public partial class CidadeMetadado
    {
        [StringLength(255,ErrorMessage = "O nome deve ter no maximo 255 caracteres")]
        public virtual string Nome { get; set; }
    }
}
