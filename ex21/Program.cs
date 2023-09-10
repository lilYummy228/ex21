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
            int[] array = new int[0];
            int sumOfNumbers = 0;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("sum - суммировать введенные числа\nexit - выйти из программы\n");
                Console.Write("Введите команду или число: ");
                string command = Console.ReadLine();

                if (command != "exit" && command != "sum")
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
                else if (command == "exit")
                {
                    break;
                }
                else if (command == "sum")
                {
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
