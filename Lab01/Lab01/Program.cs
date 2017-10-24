using System;

namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double  b, c, d, e, f, g;
            Console.Write("Please enter value :");

            double a = Convert.ToInt32(Console.ReadLine());
            b = a / 1000; // แปลงจาก km to m
            c = b / 149597870691; //แปลงจาก m to a.u.
            Console.WriteLine("km to A.U. | {0} ---> {1})", a, c );
            const double lightSpeed = 186000d;   // miles per second
            const double mileTokm = 1.609344;
            d = lightSpeed * mileTokm;
            e = a / d;
            Console.WriteLine("TimeOfLight = {0} sec", e);
            f = e / 60;
            Console.WriteLine("TimeOfLight = {0} min", f);
        }
    }
}
