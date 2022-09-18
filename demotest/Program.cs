using System;
namespace HelloWorldApplication
{
    /* 类名为 HelloWorld */
    class HelloWorld
    {
        /* main函数 */
        static void Main(string[] args)
        {
            int a = 100;
            char b = 'a';
            int c = b;
            char d = (char)a;
            int e = 45, f = 56;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //输入数据
            //string str = Console.ReadLine();
            //Console.WriteLine("str:"+str);
            //bool类型
            bool m = e == f;
            bool n = e < f;
            bool x = e > f;
            bool y = e != f;

            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("The first demo：\"001test\\n\"");

            
            Console.ReadKey();
        }

    }
}