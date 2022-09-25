using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AppiTest.Models
{
    public class Humanos
    {
        [Key]
        public int Id { get; set; }
        [AllowNull]
        public string Nombre { get; set; }
        [AllowNull]
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
    }
}
