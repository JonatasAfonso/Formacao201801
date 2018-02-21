using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadeMeuMedico.Dto
{
    public class MedicoDto
    {
        public int Id { get; set; }
        [Display(Name="Nome do Médico")]
        public string Nome { get; set; }

        [Display(Name = "Identificacao")]
        public string NumeroCelula { get; set; }

        [Display(Name = "Nome da Cidade")]
        public int CidadeId { get; set; }

        [Display(Name = "Nome da Especialidade")]
        public int EspecialidadeId { get; set; }
    }
}
