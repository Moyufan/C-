using System;

namespace 值传递和引用传递
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型 ： int double decimal char bool struct enmu valueType ---->object
            //引用类型 ： string  数组 集合  Object 接口
            //值类型在传递的时候传递的是值本身
            //引用类型在传递的时候传的是引用，或者说是地址
            //int n = 10;
            ////int n2 = n;
            ////n2 = 20;
            ////Console.WriteLine(n);
            ////Console.WriteLine(n2);
            ////传递形参不影响n本身
            // int n2 =test(n);
            //Console.WriteLine(n);
            //Console.WriteLine(n2);
            //Console.ReadKey();


            //Person P1 = new Person();
            //P1.Name = "张三";
            //Person P2 = P1;
            //P2.Name = "李四";
            //Console.WriteLine(P1.Name);


            //ref 将一个值传递转成引用传递
            int n = 10;
            test(ref n);
            //n 与 nn 地址一样
            //            &n
            //0x00000000002bdb00
            //    * &n: 0
            // & nn
            //0x00000000002bdb00
            //    * &nn: 15
            Console.WriteLine(n);
            Console.ReadKey();
        }
        public static void test(ref int nn)
        {
            nn += 5;
        }
    }
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
}
