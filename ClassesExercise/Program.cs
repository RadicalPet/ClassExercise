using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarah";
            string birthDate = "16/04/1985";
            string email = "sahara.braun@gmail.com";
            DateTime dateOfBirth = Convert.ToDateTime(birthDate);

            string name2 = "Elise";
            string birthDate2 = "01/02/1971";
            DateTime dateOfBirth2 = Convert.ToDateTime(birthDate2); 

            Customer customer1 = new Customer(name, dateOfBirth, email);
            Customer customer2 = new Customer(name2, dateOfBirth2);

            Console.WriteLine("Name: {0}\nBirth Date: {1}\nEmail: {2}\nSignup Date: {3}\n", customer1.Name, customer1.DateOfBirth, customer1.Email, customer1.SignupDate);
            Console.WriteLine("Name: {0}\nBirth Date: {1}\nEmail: {2}\nSignup Date: {3}\n", customer2.Name, customer2.DateOfBirth, customer2.Email, customer2.SignupDate);
            Console.WriteLine("Number of Customers: {0}", Customer.getNumberOfCustomers().ToString());
        }
    }
}
