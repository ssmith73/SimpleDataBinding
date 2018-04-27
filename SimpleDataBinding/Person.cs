using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataBinding
{
    public class Person
    {
        private string name;
        public Person()
        {
        }
        public Person(string value)
        {
            this.name = value;
        }
        public string PersonName
        {
            get { return name; }
            set { name = value; }
        }
    }
}

