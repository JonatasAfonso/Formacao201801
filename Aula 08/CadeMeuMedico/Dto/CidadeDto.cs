using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadeMeuMedico.Dto
{
    public class CidadeDto
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Cidade")]
        public string Nome { get; set; }
    }
}
