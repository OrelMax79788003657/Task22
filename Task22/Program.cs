using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    internal class Program
    {
        public static int[] randomNumbers;
        static void Main()
        {
            Random r = new Random();

            Console.Write("Введите длину массива чисел: ");
            int len = int.Parse(Console.ReadLine());
            randomNumbers = new int[len];

            for (int i = 0; i < len; i++)
            {
                randomNumbers[i] = r.Next(0, 10);
            }
            Task taskSummOf = new Task(() => SummOf());
            Task taskMaxValue = new Task(() => MaxValue());

            taskSummOf.Start();
            taskMaxValue.Start();

            Console.ReadKey();
        }

        public static void SummOf()
        {
            int[] rNums = randomNumbers;
            int summ = 0;

            for (int i = 0; i < rNums.Length; i++)
            {
                summ += rNums[i];
            }
            Console.WriteLine($"Сумма всех чисел из списка: {summ}");

        }

        public static void MaxValue()
        {
            int[] rNums = randomNumbers;
            int max = rNums[0];

            for (int i = 0; i < rNums.Length; i++)
            {
                if (rNums[i] > max)
                {
                    max = rNums[i];
                }
            }
            Console.WriteLine($"Максимальное число из списка: {max}");

        }
    }
}
