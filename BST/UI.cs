﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public static class UI
    {
        public static void GetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name.");
            contestant.FirstName = Console.ReadLine();
        }
        
        public static void GetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name.");
            contestant.LastName = Console.ReadLine();
        }

        public static void GetEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter in your email address");
            contestant.EmailAddress = Console.ReadLine();
        }

        public static void DisplayFirstName(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.ReadLine();
        }

        public static void DisplayLastName(Contestant contestant)
        {
            Console.WriteLine(contestant.LastName);
            Console.ReadLine();
        }

        public static void DisplayEmail(Contestant contestant)
        {
            Console.WriteLine(contestant.EmailAddress);
            Console.ReadLine();
        }

        public static void 
    }
}
