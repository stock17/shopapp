using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace shopapp
{
    [DataContract]
    public class Customer
    {

        public static int NextId;        
        public const int MAX_AGE = 100;
        public const int MIN_AGE = 0;

        public Customer(string name, bool sex, int age, int status)
        {
            this.id = Customer.NextId++;
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.status = status;
        }

        [DataMember]
        private int id;
        public int Id
        {
            get { return id; }
        }

        [DataMember]
        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        [DataMember]
        private bool sex;
        public bool Sex
        {
            set { sex = value; }
            get { return sex; }
        }

        [DataMember]
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        [DataMember]
        private int status;
        public int Status
        {
            set { status = value;  }
            get { return status; }
        }

        public enum SocialStatus { unemployed, employee, student, pensioner }
    }

    
}
