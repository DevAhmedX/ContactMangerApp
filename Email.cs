using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerApp
{
    internal class EMail
    {
        string _email;
        string _type;
        string _description;

        public EMail(string email, string type, string description)
        {
            _email = email;
            _type = type;
            _description = description;
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
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
        public override string ToString() => $"{Type}: {Email} ({Description})";

    }
}
