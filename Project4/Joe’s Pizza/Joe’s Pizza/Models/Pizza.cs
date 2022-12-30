using System.ComponentModel.DataAnnotations;
namespace Joe_s_Pizza.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string Type { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
