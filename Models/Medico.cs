using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ConsultorioApi.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public int ConsultorioId { get; set; }
        public Consultorio Consultorio { get; set; }
    }
}