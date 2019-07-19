using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Core.Interfaces;

namespace Core.Model
{
    public class Command : IWritable
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

        public string ToHtmlString()
        {
            var style = "<style>" +
                        "#order {font-size: 32px;text-align: center;}" +
                        ".line {margin-bottom: 0.5%;width: 98vw;font-size: 20px;}" +
                        ".line:nth-child(odd) {background: white;}" +
                        ".line:nth-child(even){background: gray;}" +
                        ".product {text-align: left;width: 85%;display: inline-block;}" +
                        ".price {text-align: right;width:14%;display: inline-block;}" +
                        "</style>";
            var header = $"<div id=\"order\">Order #{Id}</div>";
            var productsString = new StringBuilder();
            foreach (KeyValuePair<Product, int> entry in Products)
            {
                var price = entry.Value * entry.Key.Price;
                productsString.Append(
                    $"<div class=\"line\"><div class=\"product\"><b>{entry.Key.Name}</b>&nbsp;:&nbsp;{entry.Value}</div>&nbsp;<div class=\"price\">{price} €</div></div>");
            }

            var total = $"<div class=\"line\"><div class=\"product\">&nbsp;</div>Total {Price} €</div>";
            var stringBuilder = new StringBuilder();
            stringBuilder
                .Append("<html><head>")
                .Append(style)
                .Append("</style><body>")
                .Append(header)
                .Append(productsString)
                .Append(total)
                .Append("</body></html>");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return
                $"{nameof(Id)}: {Id}, {nameof(Products)}: {Products}, {nameof(Price)}: {Price}, {nameof(Duration)}: {Duration}";
        }
    }
}