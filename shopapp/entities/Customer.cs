using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp
{
    public class Customer
    {

        public Customer(int id, string name, bool sex, int age, int status)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.status = status;
        }

        private int id;
        public int Id
        {
            get { return id; }
        }

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
            set { name = value; }
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
