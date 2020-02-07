using System;

public class StartUp
{
    public static void Main()
    {
        int number = Int32.Parse(Console.ReadLine());

        if (number > 2 && number < 10000)
        {
            Draw.FirstLine(number);
            Draw.Middle(number);
            Draw.Footer(number);
        }
    }
}