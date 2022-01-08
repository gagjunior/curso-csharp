using System.Globalization;
using System.Text;

namespace Inheritance5.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) 
            : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }

        public override string priceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" R$ ");
            sb.Append(TotalPrice());
            sb.Append($" (Customs free: R$ {CustomsFree.ToString("F2", CultureInfo.InvariantCulture)})");

            return sb.ToString();
        }
    }
}
