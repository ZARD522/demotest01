using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////输入数据
            //int age = Convert.ToInt32(Console.ReadLine());
            ////int b = Convert.ToInt32(Console.ReadLine());

            //if (age<18&&age>0)
            //{
            //    Console.WriteLine("未成年人");
            //}else if(age>=18)
            //{
            //    Console.WriteLine("成年人");
            //}else if (age < 0)
            //{
            //    Console.WriteLine("输入错误！！");
            //}



            ////判断是否是闰年
            //int year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0 && year % 100 != 0||year%400==0)
            //{
            //    Console.WriteLine("是闰年");
            //}
            //else
            //{
            //    Console.WriteLine("不是闰年");
            //}

            ////找出最大值
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int max = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //else if(c>max)
            //{
            //    max = c;
            //}
            //Console.WriteLine("max="+max);


            //冒泡排序   三个数从小到大排序
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine(a+"  "+b+"  "+c+"  ");











            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
