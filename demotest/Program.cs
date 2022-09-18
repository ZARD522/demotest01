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
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //输入数据
            string str = Console.ReadLine();
            Console.WriteLine("str:"+str);

            Console.WriteLine("Hello World!");
            Console.WriteLine("The first demo：\"001test\\n\"");
            Console.ReadKey();
        }

    }
}