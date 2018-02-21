using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CadeMeuMedico.API.Model
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Login { get; set; }

        [MaxLength(10)]
        public string Senha { get; set; }

        [MaxLength(100, ErrorMessage = "Muito grande")]
        [MinLength(10, ErrorMessage = "Muito pequeno")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
