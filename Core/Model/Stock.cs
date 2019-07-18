namespace Core.Model
{
    public class Stock
    {
        public Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }

        public Stock(Ingredient ingredient, int quantity)
        {
            Ingredient = ingredient;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{nameof(Ingredient)}: {Ingredient}, {nameof(Quantity)}: {Quantity}";
        }
    }
}