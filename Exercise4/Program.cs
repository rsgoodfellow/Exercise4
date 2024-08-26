using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length; //declare length variable
            int width; //declare width variable

            Console.Write("Enter the length of the rectangle: "); //asks for user input
            length = Convert.ToInt32(Console.ReadLine()); //converts user input to int and stores it as length
            Console.Write("Enter the width of the rectangle: "); //asks for user input
            width = Convert.ToInt32(Console.ReadLine()); //converts user input to int and stores it as width
            Console.WriteLine(""); //enters blank line
            int area = length * width; //calculates area
            int perimeter = length * 2 + width * 2; //calculates perimeter
            Console.WriteLine("Results:"); //displays text
            Console.WriteLine("Area of the rectangle: " + area); //displays area of the rectangle
            Console.WriteLine("Perimeter of the rectangle: " + perimeter); //displays rectangle perimeter
            Console.ReadKey(); //displays output
        }
    }
}
