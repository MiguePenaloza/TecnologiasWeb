using System;

namespace IntroClassCSharp
{
    public class Shape : Object
    {
        public string Name { get; set; }
        public string Color { get; set; }

        


        public virtual void Show()
        {
            //Console.WriteLine(string.Format("my name is {0} shape", name));
            Console.WriteLine(string.Format($"my name is {Name} shape"));
        }
    }


    public class Square : Shape
    {
        public override void Show()
        {
            Console.WriteLine($"im a squeare {Name}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Shape myShape = new Shape("basic");
            var myShape = new Square() {Name = "basic", Color = "blue" };
            myShape.Show();

            Console.WriteLine("Hello World!");
        }
    }
}
