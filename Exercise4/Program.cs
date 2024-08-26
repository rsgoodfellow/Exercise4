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
            int length;
            int width;

            Console.Write("Enter the length of the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            int area = length * width;
            int perimeter = length * 2 + width * 2;
            Console.WriteLine("Results:");
            Console.WriteLine("Area of the rectangle: " + area);
            Console.WriteLine("Perimeter of the rectangle: " + perimeter);
            Console.ReadKey();
        }
    }
}
