using System.Collections.Generic;

namespace Carfleet
{
    public class Person
    {
        private string _name;
        private string _firstname;
        private string _phoneNumber;
        private string _emailAddress;
        private List<string> _languages;
        
        public Person(string name, string firstname, string phoneNumber, string emailAddress)
        {
            _name = name;
            _firstname = firstname;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
        }
        
        public Person(string name, string firstname, string phoneNumber, string emailAddress,List<string> languages)
        {
            _name = name;
            _firstname = firstname;
            _phoneNumber = phoneNumber;
            _emailAddress = emailAddress;
            _languages = languages;
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
        
        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {
                if (_languages.Count > 0)
                {
                    _languages.AddRange(value);
                }
                
                foreach (var item in _languages)
                {
                    if (value.Contains(item))
                    {
                        _languages.Remove(item);
                    }
                    return;
                }
                
                _languages = value;
            }
        }
        
        
    }
}