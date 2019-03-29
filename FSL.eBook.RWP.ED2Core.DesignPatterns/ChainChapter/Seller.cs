
namespace FSL.eBook.RWP.ED2Core.DesignPatterns.ChainChapter
{
    public sealed class Seller
    {
        public Seller(
            string name, 
            double maxDiscount)
        {
            Name = name;
            MaxDiscount = maxDiscount;
        }

        public string Name { get; set; }

        public double MaxDiscount { get; set; }

        private Seller _superior { get; set; }

        public void SetSuperior(
            Seller superior)
        {
            _superior = superior;
        }

        public Discount ApplyDiscount(
            double discount)
        {
            Discount result = null;

            if (discount <= MaxDiscount)
            {
                result = new Discount()
                {
                    SellerName = Name,
                    Value = discount,
                    Approved = true
                };
            }
            else if (_superior != null)
            {
                return _superior.ApplyDiscount(discount);
            }
            else
            {
                result = new Discount();
            }

            return result;
        }
    }
}