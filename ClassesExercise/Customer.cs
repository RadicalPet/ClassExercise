using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class Customer
    {
        private static int numberOfCustomers = 0;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public DateTime SignupDate { get; set; }

        private int customerId; 

        public Customer(string name, DateTime dateOfBirth)
            : this(name, dateOfBirth, "no email given", DateTime.Now)
        {
        }
        public Customer(string name, DateTime dateOfBirth, string email)
            : this(name, dateOfBirth, email, DateTime.Now)
        {
        }
        public Customer(string name, DateTime dateOfBirth, DateTime signupDate)
            : this(name, dateOfBirth, "no email given", signupDate)
        {
        }
        
        public Customer(string name, DateTime dateOfBirth, string email, DateTime signupDate)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Email = email;
            this.SignupDate = signupDate;
            Customer.numberOfCustomers = Customer.numberOfCustomers + 1;
            this.customerId = Customer.numberOfCustomers;
        }
        public static int getNumberOfCustomers()
        {
            return Customer.numberOfCustomers;
        }
  
    }
}
