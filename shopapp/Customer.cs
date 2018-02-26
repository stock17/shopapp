using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp
{
    class Customer
    {
        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        private bool sex;
        public bool Sex
        {
            set { sex = value; }
            get { return sex; }
        }

        private string name;
        public string Name
        {
            set { Name = value; }
            get { return name; }
        }

        private int status;
        public int Status
        {
            set { status = value;  }
            get { return status; }
        }

    }
}
