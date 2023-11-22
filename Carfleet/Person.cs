using System.Collections.Generic;

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
        
        public Person(string name, string firstname, string phoneNumber, string emailAddress,List<string> language)
        {
            _name = name;
            _firstname = firstname;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _language = language.ToString();
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        
        public string Phonenumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        
        public string Emailaddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                _emailAddress = value;
            }
        }
        
        public string Languages
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
            }
        }
        
        
    }
}