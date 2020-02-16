using System;

namespace IntroClassCSharpReview
{
    public class Shape : Object
    {
        public string Name { get; set; }
        public string Color { get; set; }



        public virtual void Show()
        {
            //Console.WriteLine(string.Format("My name is {0} shape", name));
            Console.WriteLine($"My name is {Name} shape");       
        }
    }

    
    public class Square : Shape
    {
        public override void Show()
        {
            Console.WriteLine($"I'm a square {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Shape myShape = new Shape("basic");
            //var myShape = new Shape() { Name = "basic", Color = "blue" };
            Shape myShape = new Square() { Name = "basic", Color = "blue" };
            myShape.Show();

            Console.WriteLine("Hello World!");
        
        }
    }
}
