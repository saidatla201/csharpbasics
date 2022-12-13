using Microsoft.Win32.SafeHandles;

namespace variables
{
    internal class Program
    {
        public static void Main()
        // variables 
        {
            int age = 24;
            string firstname = "sai";
            string lastname = "datla";
            string fullname = firstname + lastname;
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your full name is " + fullname);
            Console.ReadLine();
        }

        }
    }