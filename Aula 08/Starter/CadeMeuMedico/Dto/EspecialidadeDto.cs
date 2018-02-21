using System.ComponentModel.DataAnnotations;


namespace CadeMeuMedico.Dto
{
    public class EspecialidadeDto
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Especialidade")]
        public string Nome { get; set; }
    }
}
