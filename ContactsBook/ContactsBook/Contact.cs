using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBook
{
    internal class Contact : Book
    {
        public uint _id;
        private string _firstName;
        private string _lastName;
        private string _addres;
        private uint _phoneNumber;
        public string FirstName 
        { 
            get {  return _firstName; } 
            set { _firstName = value; } 
        }
        public string LastName 
        { 
            get { return _lastName; } 
            set { value = _lastName; } 
        }
        public string Addres 
        { 
            get { return _addres; } 
            set { value = _addres; } 
        }
        public uint PhoneNumber 
        { 
            get { return _phoneNumber ; } 
            set { value = _phoneNumber; } 
        }

    }
}
