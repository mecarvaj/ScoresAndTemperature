namespace ScoresAndTemperature
{
    using System;

    class Program
    {
        const int MinScore = 0;
        const int MaxScore = 100;

        static void Main()
        {
            Ejercicio1();
            Ejercicio2();
        }
        static void Ejercicio1()
        {
            int totalScores = 0;
            int count = 0;
            int minScore = MaxScore;
            int maxScore = MinScore;

            while (true)
            {
                Console.Write("Enter a test score (0-100): ");
                string input = Console.ReadLine();
                int score;

                if (!int.TryParse(input, out score) || score < MinScore || score > MaxScore)
                {
                    break;
                }

                totalScores += score;
                count++;
                minScore = Math.Min(minScore, score);
                maxScore = Math.Max(maxScore, score);
            }

            if (count > 0)
            {
                double averageScore = (double)totalScores / count;

                Console.WriteLine("Average score: " + averageScore);
                Console.WriteLine("Minimum score: " + minScore);
                Console.WriteLine("Maximum score: " + maxScore);
            }
            else
            {
                Console.WriteLine("No valid scores entered.");
            }
        }
        static void Ejercicio2()
        {
            Console.Write("Enter the starting Fahrenheit temperature: ");
            int startTemp = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending Fahrenheit temperature: ");
            int endTemp = int.Parse(Console.ReadLine());

            Console.Write("Enter the step size: ");
            int stepSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Fahrenheit  Celsius");
            Console.WriteLine("-------------------");

            for (int temp = startTemp; temp <= endTemp; temp += stepSize)
            {
                double celsius = (temp - 32) * 5.0 / 9.0;
                Console.WriteLine($"{temp,-12} {celsius,0:F2}");
            }
        }
    }

}