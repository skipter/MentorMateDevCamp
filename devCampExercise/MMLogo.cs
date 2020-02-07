using System;

namespace devCampExercise
{
    public class MMLogo
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (!(number > 2 && number < 10000))
            {
                number = int.Parse(Console.ReadLine());
            }

            //First Line
            Console.WriteLine(new string('-', number) + new string('*', number) + new string('-', number) + new string('*', number) +
                new string('-', number * 2) + new string('*', number) + new string('-', number) + new string('*', number) +
                new string('-', number));

            //Upper part
            for (int i = 1; i < (number / 2) + 1; i++)
            {
                Console.WriteLine(new string('-', number - i) + new string('*', number + i * 2 ) + new string('-', number - i * 2) + new string('*', number + i * 2) 
                    + new string('-', number - i) + new string('-', number - i) + new string('*', number + i * 2) + new string('-', number - i * 2) + new string('*', number + i * 2)
                    + new string('-', number - i));
            }

            //Footer
            for (int i = 0; i < number / 2 + 1; i++)
            {
                Console.WriteLine(new string('-', (number / 2) - i) + new string('*', number) + new string('-', i + 1) + new string('-', i) + new string('*', number) 
                    + new string('*', number - i * 2 - 1) + new string('-', i + 1) + new string('-', i) + new string('*', number) + new string('-', (number / 2)- i)
                    + new string('-', (number / 2) - i) + new string('*', number) + new string('-', i + 1) + new string('-', i) + new string('*', number)
                    + new string('*', number - i * 2 - 1) + new string('-', i + 1) + new string('-', i) + new string('*', number) + new string('-', (number / 2) - i));
            }
        }
    }
}
