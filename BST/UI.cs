using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public static class UI
    {
        private static string firstName;
        private static string lastName;
        private static string emailAddress;
        private static int regNumber;


        public static void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first and last name.");
            firstName = Console.ReadLine();
        }
        
        public static void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first and last name.");
            lastName = Console.ReadLine();
        }

        public static void GetEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter in your email address");
            emailAddress = Console.ReadLine();
        }

        public static void GetRegistrationNumber(Contestant contestant)
        {
            Console.WriteLine("Please enter your 4 digit registration number.");
            int regNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
