namespace VcardManager
{
    public class Contact
    {
        private string fullName;
        private string telephoneNumber;
        private string email;

        public string FullName
        {
            get => fullName;
            set => fullName = value;
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
            this.fullName = "Unknown";
            this.telephoneNumber = "Unknown";
            this.email = "Unknown";
        }

        public override string ToString()
        {
            return $"NAME: {this.fullName}, TEL: {this.telephoneNumber}, EMAIL: {this.email}";
        }
    }
}