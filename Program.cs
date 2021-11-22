using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area = rect.RectArea();
            Console.WriteLine("The area = " + area);
            int circum = rect.RectCircum();
            Console.WriteLine("The circumference = " + circum);
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        public int width = 10;
        public int length = 5;
        public int area;
        public int circum;
        //method for computing the area
        public int RectArea()
        {
            area = width * length;
            return area;
        }
        //method for computing the circumference
        public int RectCircum()
        {
            circum = 2 * (length + width);
            return circum;
        }
    }
}
