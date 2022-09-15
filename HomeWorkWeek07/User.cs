using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Task0701user
namespace HomeWorkWeek07
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public User(string name, string surname, int age, string country)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Country = country;
        }
    }
}
#endregion