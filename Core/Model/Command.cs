using System.Collections.Generic;

namespace Core.Model
{
    public class Command
    {
        private int Id { get; set; }
        private Dictionary<Product, int> Products { get; }
        private double Price { get; }
        private double Duration { get; }
    }
}