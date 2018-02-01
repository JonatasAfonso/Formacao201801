using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MetadataType(typeof(Especialidade))]
    public partial class EspecialidadeMetadado
    {
        [StringLength(255, ErrorMessage = "O tamanho maximo é de 255")]
        public virtual string Nome { get; set; }
    }
}
