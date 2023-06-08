using System;

namespace blokcxema.zadacha_11.sem2
{
    class Program
    {
        static void Main()
        {
            int a, n, min = 0, i, j, max = 0;
            try
            {
                Console.WriteLine("Введите количество элементов массива ");
                n = int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) { Main(); }
                return;
            }
            Random rand = new Random();
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, 20);
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();
            min = array[0];
            max = array[0];
            for ( i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("минимальное - {0} , максимальное - {1}" , min, max);
            for (i = min+1; i < max; i++) 
            {
                bool found = false;
                for (j = 0; j < array.Length; j++)
                {
                    if (array[j] == i)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.Write("{0,4}", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) { Main(); }
            return;
        }
    }
}
