namespace Core.Model
{
    public class Allergen
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Allergen(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}