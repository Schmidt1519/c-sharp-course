using System;

namespace AbstractClassesMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyAbstractClass abClass = new MyAbstractClass();

            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();

        }
    }

    abstract class MyAbstractClass
    {
        private string message = "Good morning!";
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }

        public abstract void PrintMessageAbstract();
    }

    class ClassA : MyAbstractClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("Simplicity is the ultimate sophistication");
        }
    }
}
