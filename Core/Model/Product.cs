using System.Collections.Generic;
using Core.Interfaces;

namespace Core.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double Duration { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, List<Ingredient> ingredients, double duration, double price,
            Category category)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            Duration = duration;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return
                $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Ingredients)}: {Ingredients}, {nameof(Duration)}: {Duration}, {nameof(Price)}: {Price}, {nameof(Category)}: {Category}";
        }
    }
}