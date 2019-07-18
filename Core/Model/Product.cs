using System.Collections.Generic;

namespace Core.Model
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private List<Ingredient> Ingredients { get; set; }
        private double Duration { get; set; }
        private double Price { get; set; }
        private Category Category { get; set; }
    }
}