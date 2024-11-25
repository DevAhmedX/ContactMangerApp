using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp
{
    internal class Phone
    {
        private string _phone;
        private string _type;
        private string _description;

        public Phone(string phone, string type, string description)
        {
            _phone = phone;
            _type = type;
            _description = description;
        }

        public string PhoneNumber
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string ToString() => $"{Type}: {PhoneNumber} ({Description})";
    }
}
