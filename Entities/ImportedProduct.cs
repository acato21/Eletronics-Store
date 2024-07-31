using System.Globalization;
using System.Text;

namespace EletronicsStore.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            string priceTag = base.PriceTag();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{priceTag} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})")

            return sb.ToString();
        }
    }
}
