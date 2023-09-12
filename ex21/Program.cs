using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "exit";
            const string CommandSum = "sum";
            const string CommandClear = "clear";

            int[] array = new int[0];
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("Введенные числа:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}|");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"{CommandSum} - суммировать введенные числа\n{CommandExit} - выйти из программы\n" +
                    $"{CommandClear} - очистить введенные числа\n");
                Console.Write("Введите команду или число: ");
                string command = Console.ReadLine();

                if (command == CommandClear)
                {
                    Array.Clear(array, 0, array.Length);
                    int[] tempArray = new int[0];
                    array = tempArray;
                    Console.WriteLine("Введеные числа были очищены...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (command != CommandExit && command != CommandSum && command != CommandClear)
                {
                    int number = Convert.ToInt32(command);
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = number;
                    array = tempArray;
                    Console.Clear();
                }
                else if (command == CommandExit)

                {
                    isOpen = false;
                }
                else if (command == CommandSum)
                {
                    int sumOfNumbers = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sumOfNumbers += array[i];
                    }

                    Console.WriteLine($"Сумма всех чисел равняется: {sumOfNumbers}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
