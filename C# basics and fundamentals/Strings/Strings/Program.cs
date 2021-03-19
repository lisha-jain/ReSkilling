using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = " Lisha ";
            var lastName = "Jain";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Jhon", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi Lisha\nLook into the following paths\nc:\\folder1\\folder2";
            Console.WriteLine(text);
        }
    }
}
