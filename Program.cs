//KÖTÜ KOD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add("Mika", "Tauriainen", "111");
            customerManager.Add("Michael", "Stipe", "222");
            customerManager.Add("Doug", "Robb", "333");
            customerManager.Add("Michael", "Barnes", "444");
        }
    }

    class CustomerManager
    {
        public void Add(string firstName, string lastName, string identityNumber)
        {
            Console.WriteLine("Eklendi");
        }
    }
}

//TEMİZ KOD


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                FirstName = "Mika",
                LastName = "Tauriainen",
                IdentityNumber = "111"
            });

            customerManager.Add(new Customer
            {
                FirstName = "Michael",
                LastName = "Stipe",
                IdentityNumber = "222"
            });

            customerManager.Add(new Customer
            {
                FirstName = "Doug",
                LastName = "Robb",
                IdentityNumber = "333"
            });
            customerManager.Add(new Customer
            {
                FirstName = "Michael",
                LastName = "Barnes",
                IdentityNumber = "444"
            });

        }
    }

    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }
}
