using System;

namespace 显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MQBird maque = new MQBird();
            maque.Fly();
            QQBird qq = new QQBird();
            qq.Fly();
            qq.Eat();
            Ifly qwq = new QQBird();
            qwq.Fly();
            
            Console.ReadKey();

        }
    }
    //接口像是一种功能，给有此能力的对象继承
    public class MQBird:Ifly
    {
        public void Fly()
        {
            Console.WriteLine("麻雀飞呀飞。。。");
        }
    }
    public class QQBird:Ifly
    {
        public void Fly()
        {
            Console.WriteLine("企鹅也会飞。");

        }
        void Ifly.Fly()
        {
            Console.WriteLine("企鹅用脚飞哦O(∩_∩)O哈哈~");
        }
        public void  Eat()
        {
            Console.WriteLine("企鹅爱吃。。。");
        }
    }

    public interface Ifly
    {
        void Fly();
    }
}
