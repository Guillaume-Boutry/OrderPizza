using System.Collections.Generic;
using System.Net.Mail;

namespace Core.Model
{
    public class Command
    {
        public int Id { get; set; }
        public Dictionary<Product, int> Products { get; }
        public double Price { get; private set; }
        public double Duration { get; private set; }

        public Command(int id, Dictionary<Product, int> products)
        {
            Id = id;
            Products = products;
            Price = CalculatePrice();
            Duration = CalculateDuration();
        }

        public Command(Dictionary<Product, int> products) : this(0, products)
        {
        }

        private double CalculatePrice()
        {
            double price = 0;
            foreach (KeyValuePair<Product, int> entry in Products)
            {
                price += entry.Value * entry.Key.Price;
            }

            return price;
        }

        private double CalculateDuration()
        {
            double duration = 0;
            foreach (KeyValuePair<Product, int> entry in Products)
            {
                duration += entry.Value * entry.Key.Duration;
            }

            return duration;
        }
        
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Products)}: {Products}, {nameof(Price)}: {Price}, {nameof(Duration)}: {Duration}";
        }
    }
    
    
}