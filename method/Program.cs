using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }


        enum Day
        {
            Sun, Mon, tue, Wed, thu, Fri, Sat
        }


        struct Student
        {
            public int num;
            public string name;
            public int age;
            public char sex;


            public void SetValues(int nu, string na, int ag, char se)
            {
                num = nu;
                name = na;
                age = ag;
                sex = se;
            }
        }

        

        delegate int Mul(int a,int b);//委托



        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Add(a, b);
            //Console.WriteLine(c);


            //Day day = Day.Mon;
            //Console.WriteLine(day);


            Student stu;
            stu.num = 2022024;
            stu.name = "ZARD";
            stu.age = 22;
            stu.sex = 'M';
            Console.WriteLine("学号：" + stu.num + "\n姓名：" + stu.name + "\n性别: " + stu.sex + "\n年龄：" + stu.age);

            Student stu1=new Student();
            stu1.SetValues(2022,"Cooper",21,'F');
            Console.WriteLine("学号："+stu1.num+"\n姓名："+stu1.name+"\n性别: "+stu1.sex+"\n年龄："+stu1.age);



            Mul add1;
            add1 = Add;
            Console.WriteLine(add1(2,5));

            Console.ReadKey();
        }
        
    }
}
