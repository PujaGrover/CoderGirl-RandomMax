using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.

            int randomMax = 0;

            for (int i = 1; i < 101; i++)
            {
                int randomInteger = new Random().Next(0, 1000);
                //Console.WriteLine($"{i})" + randomInteger);

                if (randomInteger > randomMax)
                {
                    randomMax = randomInteger;
                }
            }
            Console.WriteLine(randomMax);

            Console.ReadLine();
        }
    }
}
