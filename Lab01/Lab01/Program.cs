using System;

public class MathTest
{
    static void Main(string[] args)
    {
        for (float i = -2; i < Math.PI * 4.5F; i += 0.35F)
        {
            Console.WriteLine("The tan {0,10:F} = {1,-10:F6}" +
            spaces(Math.Tan(i)) + "*", i, Math.Tan(i));
        }
    }
    private static string spaces(double val)
    {
        string SpaceString = new String(' ', ((int)(val *0.50)) + 10);
        return SpaceString;
    }
}
