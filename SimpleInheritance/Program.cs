using System;
using System.ComponentModel.DataAnnotations;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 

    class Cat : Animal
    {
        public int age;
        public int weight;
        public int height;

        // constructor
        public Cat()
            :base()
        {
            age = 0;
            weight = 0;
            height = 0;

        }
        //parameterized constructor
        public Cat(string name, int age, int weight, int height)
            :base(name)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public void displayfields()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Height: {height}");
        }

    }

    class Bird : Animal
    {
        public string color;
        public int weight;
        public int height;

        // constructor
        public Bird()
            : base()
        {
            color = "";
            weight = 0;
            height = 0;

        }
        //parameterized constructor
        public Bird(string name, string color, int weight, int height)
            : base(name)
        {
            this.color = color;
            this.weight = weight;
            this.height = height;
        }

        public void displayfields()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Height: {height}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Cat myCat = new Cat();
            myCat.name = "CatName";
            myCat.age = 10;
            myCat.weight = 123;
            myCat.height = 123;
            myCat.displayfields();

            //derived class object using parameterized constructor
            Cat newCat = new Cat("CatNameTwo", 123, 321, 321);
            newCat.displayfields();

            // 2nd class derive
            Bird myBird = new Bird();
            myBird.name = "BirdName";
            myBird.color = "White";
            myBird.weight = 321;
            myBird.height = 321;
            myBird.displayfields();

            // para
            Bird newBird = new Bird("BirdNameTwo", "Black", 321, 321);
            newBird.displayfields();

        }

    }
}