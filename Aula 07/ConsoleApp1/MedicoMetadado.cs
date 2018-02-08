using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MetadataType(typeof(Medico))]
    public class MedicoMetadado
    {
        [StringLength(255, ErrorMessage = "Maximo 255")]
        public virtual string Nome { get; set; }

        [StringLength(30, ErrorMessage = "Maximo 30")]
        [RegularExpression("[D]", ErrorMessage = "apenas digitos")]
        public virtual string Crm { get; set; }

        [StringLength(100, ErrorMessage = "Maximo 100")]
        public virtual string Endereco { get; set; }
        [StringLength(100, ErrorMessage = "Maximo 100")]
        public virtual string Bairro { get; set; }

        [StringLength(100, ErrorMessage = "Maximo 100")]
        [EmailAddress]
        public virtual string Email { get; set; }

        [Required]
        [Range(0, 1)]
        public virtual int AtendePorConvenio { get; set; }

        [Required]
        [Range(0, 1)]
        public virtual int TemClinica { get; set; }

        [StringLength(100, ErrorMessage = "Maximo 100")]
        public virtual string WebsiteBlog { get; set; }
    }
}
