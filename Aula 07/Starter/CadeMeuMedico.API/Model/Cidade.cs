using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadeMeuMedico.API.Model
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Fabio zoando a galera")]
        public string Nome { get; set; }

        public virtual List<Medico> Medicos { get; set; }
    }

}
