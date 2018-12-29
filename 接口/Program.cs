using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //虚方法，抽象类，接口，实现多态的三种方法
            NBAplayer nba = new Student();
            nba.KouLan();
            Superman fly = new Teacher();
            fly.Fly();
            Console.ReadKey();
           
        }

    }

    public class Person
    {
        public void eat()
        {
            Console.WriteLine("人会吃");
        }
    }

    //一个子类只允许一个父类，但是可以继承多个接口
    //子类继承接口后，必须实现接口中的所有方法
    //接口，抽象类不可以创建对象
    //接口中只允许出现方法，默认public修饰，不能包含字段
    //接口与接口之间可以继承，多继承，不可以继承与类
    public class Student : Person, NBAplayer, Superman
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣烂了");
        }

        void Superman.Fly()
        {
            Console.WriteLine("学生可以飞了");
        }
    }

    public class Teacher : NBAplayer, Superman
    {
        public void Fly()
        {
            Console.WriteLine("老师可以飞了");
        }

        public void KouLan()
        {
            Console.WriteLine("老师可以扣烂了");
        }
    }
    public interface NBAplayer
    {
        void KouLan();     
               
    }

    public interface Superman
    {
        void Fly();
    }
    //public class NBAplaer 
    //{
    //    public void Koulan()
    //    {
    //        Console.WriteLine("NBA球员可以扣篮！");
    //    }
    //}
    //public class SuperMan 
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("超人飞、、、、、");
    //    }
    //}
}
