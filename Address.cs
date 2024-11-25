using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp
{
    internal class Address
    {
        private string _place;
        private string _type;
        private string _description;

        public Address(string place, string type, string description)
        {
            _place = place;
            _type = type;
            _description = description;
        }

        public string Place
        {
            get { return _place; }
            set { _place = value; }
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
        public override string ToString() => $"{Type}: {Place} ({Description})";
    }
}
