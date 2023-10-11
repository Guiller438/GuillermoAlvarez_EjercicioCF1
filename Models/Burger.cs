using System.ComponentModel.DataAnnotations;

namespace GuillermoAlvarez_EjercicioCF1.Models
{
    public class Burger
    {
        public int ID{ get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }

       
    }
}
