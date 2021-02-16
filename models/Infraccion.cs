using System.ComponentModel.DataAnnotations;

namespace Accidentes_Console.models
{
    public class Infraccion
    {
        [Key]
        public int InfraccionId {get; set;}

        [Required]
        public string Cedula {get; set;}

        public string Name {get; set;}

        public string Apellido {get; set;}

        
    }
}