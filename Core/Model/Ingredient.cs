using System.Collections.Generic;

namespace Core.Model
{
    public class Ingredient
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private List<Allergen> Allergens { get; set; }
    }
}