namespace Carfleet
{
    public class Person
    {
        private string _name;
        private string _firstname;
        private string _phoneNumber;
        private string _emailAddress;
        private string _language;
        
        public Person(string name, string firstname, string phoneNumber, string emailAddress)
        {
            _name = name;
            _firstname = firstname;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
        }
        
        public Person(string name, string firstname, string phoneNumber, string emailAddress, string language)
        {
            _name = name;
            _firstname = firstname;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _language = language;
        }
    }
}