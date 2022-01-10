using System.Text;

namespace InheritanceAndPolymorphism.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFactureDate) 
            : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (used) ");
            sb.Append($"R$ {Price} ");
            sb.Append($"(Manufacture date: {ManuFactureDate.ToString("dd/MM/yyyy")})");

            return sb.ToString();
        }
    }
}
