namespace RDLC_Windows_CS
{
    public class Customer
    {
        private string _address;
        private string _city;
        private string _name;
        private string _state;
        private string _zip;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
    };
}