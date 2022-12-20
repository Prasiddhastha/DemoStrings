using System;
namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Prasiddha";
            var lastName = "Shrestha";
            //concatenation
            var fullName = firstName + " " + lastName;
            //format method
            var myFullName = string.Format("{0} {1}", firstName, lastName);
            var names = new string[3] { "prasi", "khushbu", "shrestha" };
            //join method
            var joinName = string.Join(",", names);
            Console.WriteLine(joinName);//join method
            Console.WriteLine(fullName);//concatenation
            Console.WriteLine(myFullName);//format method

            var path = @"Hi Mosh
Lets look at verbatim strings
c:\program\project\ram";//verbatim string prefix by @
            Console.WriteLine(path);
        }
    }
}
