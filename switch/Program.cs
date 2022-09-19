using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("输入错误！！！");
            //        break;
            //}



            int[] arr = { 1, 2, 5, 9 ,6,7,8,0,4};
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"  ");
            }
            Console.WriteLine("\n");


            int[] ages;
            ages = new int[] { 1,2,9,8,4,6,5,7,3};
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write(ages[i]+"  ");
            }


            Console.ReadKey();
        }
    }
}
