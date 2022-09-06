class Address
    {
        private string index;
        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        private string country;
        public string Country
        {
            get { return index; }
            set { index = value; }
        }
        private string city;
        public string City
        {
            get { return index; }
            set { index = value; }
        }
        private string street;
        public string Street
        {
            get { return index; }
            set { index = value; }
        }
        private string house;
        public string House
        {
            get { return index; }
            set { index = value; }
        }
        private string apartment;
        public string Apartment
        {
            get { return index; }
            set { index = value; }
        }

        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public void print(){
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", index, country, city, street, house, apartment);
        }
    }