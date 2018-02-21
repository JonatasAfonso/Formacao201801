using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadeMeuMedico.API.Model
{
    [Table("Medicos")]
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroCelula { get; set; }

        [ForeignKey("CidadeId")]
        public virtual Cidade Cidade { get; set; }
        public int CidadeId { get; set; }

        public virtual Especialidade Especialidade { get; set; }
        [ForeignKey("Especialidade")]
        public int EspecialidadeId { get; set; }
    }
}
