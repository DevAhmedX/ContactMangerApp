using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp
{
    internal class User
    {
        private int _id;
        private string _fName;
        private string _lName;
        private string _gender;
        private string _city;
        public List<Address> Addresses { get; } = new List<Address>();
        public List<Phone> Phones { get; } = new List<Phone>();
        public List<EMail> Emails { get; } = new List<EMail>();

        public int ID
        {
            get { return _id; }

        }

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public User(int id, string fName, string lName, string gender, string city)
        {
            _id = id;
            _fName = fName;
            _lName = lName;
            _gender = gender;
            _city = city;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {FName} {LName}, Gender: {Gender}, City: {City}";
        }
    }
}
