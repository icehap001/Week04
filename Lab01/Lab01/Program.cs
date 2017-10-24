using System;
public class intergerTest
{
    static void Main(string[] args)
    { 
        int a, b, x, y;
        int aa1, aa2, aa3, aa4, aa5, aa6, aa7, aa8, aa9, aa10;
        a = 10;
        b = 20;
        x = 5;
        y = 2;

        aa1 = a + b;
        aa2 = x - b;
        aa3 = x * b;
        aa4 = y / a;
        aa5 = b % y;
        aa6 = y + 10 % x;
        aa7 = a / 3 * 5;
        aa8 = 9 / 2 * a;
        aa9 = y % 8;
        aa10 = 100 * x + y % 2 - a;


        Console.WriteLine("1\t{0}", aa1);
        Console.WriteLine("2\t{0}", aa2);
        Console.WriteLine("3\t{0}", aa3);
        Console.WriteLine("4\t{0}", aa4);
        Console.WriteLine("5\t{0}", aa5);
        Console.WriteLine("6\t{0}", aa6);
        Console.WriteLine("7\t{0}", aa7);
        Console.WriteLine("8\t{0}", aa8);
        Console.WriteLine("9\t{0}", aa9);
        Console.WriteLine("10\t{0}", aa10);
    }
}
