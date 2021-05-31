using System;
using System.Text;

namespace ascii_to_utf8_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App for converting from ASCII to UTF8");
            Console.Write("Text: ");
            // string userInput = Console.ReadLine();
            string userInput = "Hello ÆØÅ АІЇ";
            Console.WriteLine(userInput);
            byte[] ascii_arr = Encoding.ASCII.GetBytes(userInput);
            byte[] utf8_arr = Encoding.UTF8.GetBytes(userInput);
            for (int i = 0; i < ascii_arr.Length; i++)
            {
                Console.WriteLine($"{Convert.ToChar(ascii_arr[i])} - {ascii_arr[i]} - ASCII");
                Console.WriteLine($"{Convert.ToChar(utf8_arr[i])} - {utf8_arr[i]} - UTF8");
            }
            Console.WriteLine(Encoding.ASCII.GetString(ascii_arr));
            Console.WriteLine(Encoding.UTF8.GetString(ascii_arr));
        }
    }
}
