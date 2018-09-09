using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHWT
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ввести a та b – два цілих числа. Порахувати скільки цілих чисел з діапазону [a..b] діляться на 3 без остачі.

            Console.WriteLine("Enter 2 numbers:");
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
            #endregion


            #region Ввести рядок символів. Видрукувати кожен другий символ.
            Console.WriteLine("Enter some value");
            string s=  Console.ReadLine();

            for (int i = 0; i < s.Length; i += 2)
            {
                Console.Write($"{s[i]}");
            }
            Console.ReadLine();
            #endregion

            #region Ввести назву напитку (кава, чай, сік, вода). Вивести назву напитку і його ціну.

            string[,] drinks = { { "Koffee", "Tea", "Juice", "Water" }, { "28", "25", "40", "10" } };

            string enterName = Console.ReadLine();

            for (int j = 0; j < drinks.GetLength(0); j++)
            {
                    string output = $"{enterName} price is {drinks[1, j]}";
                    Console.WriteLine(output);
                    break;
            }

            Console.ReadKey();

            #endregion

            #region Введіть послідовність додатніх цілих чисел (до першого від’ємного). Обчисліть середнє арифметичне значення введених чисел.

            int avg = 0;



            #endregion

        }
    }
}
