using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demotest001
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入数据
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("交换前：");
            Console.Write("a=" + a + "  ");
            Console.WriteLine("b=" + b);
            //数据交换
            int t;
            t = a;
            a = b;
            b = t;
            float c = (float)(a + b) / 2;
            Console.Write("交换后：");
            Console.Write("a=" + a + "  ");
            Console.WriteLine("b=" + b);
            Console.WriteLine("(" + a + "+" + b + "）" + "/2" + "=" + c);


            //数字的输出
            int d;
            Console.WriteLine("{0}+{1}={2}", a, b, d = a + b);


            //输入一个三位整数
            int num = Convert.ToInt32(Console.ReadLine());
            int ge, shi, bai;
            ge = num % 10;
            shi = num / 10 % 10;
            bai = num / 100 % 10;
            Console.WriteLine("num={0},ge={1},shi={2},bai={3}", num, ge, shi, bai);


            //++a   先自增再赋值
            int m=0, n=1;
            m = ++n;//  n++;  m=n;
            Console.Write("m=" + m+"   ");
            Console.WriteLine("n=" + n);

            //a++   先赋值再自增
            m = 0;
            n = 1;
            m = n++;//  m=n;   n++
            Console.Write("m=" + m+"   ");
            Console.WriteLine("n=" + n);
            Console.ReadKey();
        }
    }
}
