using System;

namespace AreaOfCircle
{
    class Program
    {

        public static double AreaOfCircle(int radius)
        {
            double area;

            area = Math.PI * (radius * radius);

            return area;
        }
        static void Main(string[] args)
        {
            int x;
            double area;
            Console.WriteLine("Give me the radius of a circle:");
            x = Convert.ToInt32(Console.ReadLine());

            area = AreaOfCircle(x);
            Console.WriteLine("The area of this circle is:" + area);

        }
    }
}
