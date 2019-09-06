namespace RDLC_Windows_CS
{
    public class LineItem
    {
        private int _quantity;
        private string _product;
        private decimal _unitPrice;

        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
    };
}