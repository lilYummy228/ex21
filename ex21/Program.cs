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

            int[] array = new int[0];
            bool isOpen = true;

            while (isOpen)
            {
                int sumOfNumbers = 0;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"{CommandSum} - суммировать введенные числа\n{CommandExit} - выйти из программы\n");
                Console.Write("Введите команду или число: ");
                string command = Console.ReadLine();

                if (command != CommandExit && command != CommandSum)
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
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("Введенные числа:");

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"{array[i]}|");
                    }
                }
                else if (command == CommandExit)
                {
                    isOpen = false;
                }
                else if (command == CommandSum)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        sumOfNumbers += array[i];
                    }

                    Console.WriteLine($"Сумма всех чисел равняется: {sumOfNumbers}");
                    Array.Clear(array, 0, array.Length);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
