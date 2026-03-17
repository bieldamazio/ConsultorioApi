using ConsultorioApi.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConsultorioApi.Models
{
    [Index(nameof(Cpf), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Paciente
    {
        public string Id { get; set; }
        [Required] 
        public string Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, ValidadorCpfService]
        public string Cpf { get; set; }
    }
}