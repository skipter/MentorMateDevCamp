using System;

public class Draw
{
    //First line.
    public static void FirstLine(int number)
    {
        Console.WriteLine(new string('-', number) + new string('*', number) + new string('-', number) + new string('*', number) +
            new string('-', number * 2) + new string('*', number) + new string('-', number) + new string('*', number) +
            new string('-', number));
    }

    //Middle part of the logo.
    public static void Middle(int number)
    {
        for (int i = 1; i < (number / 2) + 1; i++)
        {
            Console.WriteLine(new string('-', number - i) + new string('*', number + i * 2) + new string('-', number - i * 2) + new string('*', number + i * 2)
                + new string('-', number - i) + new string('-', number - i) + new string('*', number + i * 2) + new string('-', number - i * 2) + new string('*', number + i * 2)
                + new string('-', number - i));
        }
    }

    //Footer part of the logo.
    public static void Footer(int number)
    {
        for (int i = 0; i < number / 2 + 1; i++)
        {
            Console.WriteLine(new string('-', (number / 2) - i) + new string('*', number) + new string('-', i + 1) + new string('-', i) + new string('*', number)
                + new string('*', number - i * 2 - 1) + new string('-', i + 1) + new string('-', i) + new string('*', number) + new string('-', (number / 2) - i)
                + new string('-', (number / 2) - i) + new string('*', number) + new string('-', i + 1) + new string('-', i) + new string('*', number)
                + new string('*', number - i * 2 - 1) + new string('-', i + 1) + new string('-', i) + new string('*', number) + new string('-', (number / 2) - i));
        }
    }
}



