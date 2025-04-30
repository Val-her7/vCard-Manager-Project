namespace VcardManager
{
    public class Contact
    {
        private string firstName;
        private string telephoneNumber;
        private string email;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string TelephoneNumber
        {
            get => telephoneNumber;
            set => telephoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public Contact()
        {
            this.firstName = "Unknown";
            this.telephoneNumber = "Unknown";
            this.email = "Unknown";
        }

        public override string ToString()
        {
            return $"NAME: {this.firstName}, TEL: {this.telephoneNumber}, Email: {this.email}";
        }
    }
}