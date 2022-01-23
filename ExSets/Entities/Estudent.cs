namespace ExSets.Entities
{
    internal class Estudent
    {
        public int Id { get; set; }

        public Estudent(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Estudent))
            {
                return false;
            }

            Estudent other = obj as Estudent;

            return Id.Equals(other.Id);
        }
    }
}
