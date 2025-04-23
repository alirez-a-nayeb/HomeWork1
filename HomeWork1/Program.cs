using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static public void CalculateRectangleArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine($"Rectangle Area: {area}");
        }
        static public void IntruducePerson(string personFirstNAme,string personLastName,string city)
        {
            Console.WriteLine($"My name is {personFirstNAme} {personLastName} and Im from {city}. Nice to meet you.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rectangle Length:");
            int Length;
            bool Result;
            Result = int.TryParse(Console.ReadLine(), out Length);
            Console.WriteLine("Enter Rectangle Width:");
            int Width;
            Result=int.TryParse(Console.ReadLine(),out Width);
            CalculateRectangleArea(Length,Width);

            Console.WriteLine("Enter your First Name:");
            string FirstName=Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            string LastName=Console.ReadLine();
            Console.WriteLine("Which City Do You Live in?");
            string City=Console.ReadLine();
            IntruducePerson (FirstName,LastName,City);

        }
    }
}
