using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A
            //Console.WriteLine("Enter somethink: ");
            //string str = Console.ReadLine();
            //int a = 0;
            //int o = 0;
            //int i = 0;
            //int e = 0;/*'a', 'o', 'i', 'e'*/
            //for (int f = 0; f < str.Length; f++)
            //{
            //    if (str[f] == 'a')
            //        a++;
            //    if (str[f] == 'o')
            //        o++;
            //    if (str[f] == 'i')
            //        i++;
            //    if (str[f] == 'e')
            //        e++;
            //}
            //Console.WriteLine($"\na = {a}, \no = {o}, \ni = {i}, \ne = {e}");
            #endregion
            #region B
            //start : Console.WriteLine("Enter num of month: ");
            //int month = Int32.Parse(Console.ReadLine());
            //if (month >= 1 && month <= 12)
            //{
            //    int daysInMonth = DateTime.DaysInMonth(2018, month);
            //    Console.WriteLine($"The {month}'th month has {daysInMonth} days");
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("please use numbers only in the range '1-12'");
            //    goto start;
            //}
            #endregion
            #region C
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 nums (int): ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }                     
            int sum = 0;
            bool plusNums = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0 && i < 5)
                {
                    sum += arr[i];
                }
                if (arr[i] < 0 && i < 5)
                {
                    sum = 0;
                    plusNums = false;
                    i = 4;
                }
                if (i >= 5)
                {
                    sum += arr[i];
                }
            }
            if (plusNums)
            {
                Console.WriteLine("Sum of first five elements is " + sum);
            }
            else
            {
                Console.WriteLine("Sum of last five elements is " + sum);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
