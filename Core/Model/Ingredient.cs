using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Model
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Allergen> Allergens { get; }

        public Ingredient(int id, string name, List<Allergen> allergens)
        {
            Id = id;
            Name = name;
            Allergens = allergens;
        }

        public Ingredient(string name, List<Allergen> allergens) : this(0, name, allergens)
        {
            
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Allergens)}: {Allergens}";
        }
    }
}