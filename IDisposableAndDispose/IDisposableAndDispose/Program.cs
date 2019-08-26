using System;

namespace IDisposableAndDispose
{
    public class Base : IDisposable
    {
        public Base()
        {
            Func();
        }
        public virtual void Dispose()
        {
            Func();
        }
        public virtual void Func()
        {
            Console.WriteLine("Base class");
        }

    }

    public class Child : Base
    {
        public Child()
        {
            Func();
        }

        public override void Dispose()
        {
            Func();
            base.Dispose();
        }

        public override void Func()
        {
            Console.WriteLine("Child class");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (Base obj = new Child())
            {
                obj.Func();
            }           
        }
    }

}
