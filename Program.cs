using System;

namespace ConsoleApp11
{


    public interface Playable
    {
        void Play();
    }

    public class Guitar : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing the guitar.");
        }
    }

    public class Piano : Playable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano.");
        }
    }
    abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a Shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Adding two integers: " + calc.Add(5, 7));
            Console.WriteLine("Adding three integers: " + calc.Add(1, 2, 3));
            Console.WriteLine("Adding two doubles: " + calc.Add(2.5, 3.7));

            // Task 2: Polymorphism with Shapes
            Shape shape;

            shape = new Circle();
            shape.Draw();

            shape = new Rectangle();
            shape.Draw();

            Shape[] shapes = { new Circle(), new Rectangle() };

            Console.WriteLine("\nDrawing Shapes Polymorphically:");
            foreach (Shape s in shapes)
            {
                s.Draw();
            }

            // Task 3: Abstract class with Animals
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();  
            dog.Sleep();     

            cat.MakeSound();  
            cat.Sleep();     



            
                Playable myGuitar = new Guitar();
                Playable myPiano = new Piano();

                myGuitar.Play();
                myPiano.Play();
            }
        }
    }

