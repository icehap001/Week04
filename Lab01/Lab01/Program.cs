using System;

namespace RandomNumber
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine(randomNumber);

            Console.Write("Please enter value 1 :");
            int asd = Convert.ToInt32(Console.ReadLine());

            bool a = (randomNumber == asd);
            Console.WriteLine("{0}", a);

        }
    }


}