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
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            int[] array = new int[0];
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("sum - суммировать введенные числа\nexit - выйти из программы\n");
                Console.Write("Введите команду или число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] tempArray = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }

                tempArray[tempArray.Length - 1] = number;
                array = tempArray;
                Console.Clear();
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Введенные числа:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            //switch ()
            //{
            //    case CommandSum:
            //        break;

            //    case CommandExit:
            //        isOpen = false;
            //        break;

            //    default:
            //        Console.WriteLine("Неверная команда.");
            //        break;
            //}
        }
    }
}
