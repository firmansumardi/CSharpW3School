using System;
using System.IO;

namespace CSharpW3School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Boolean
            Console.WriteLine("\n--- Booleans ---");
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);

            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            #endregion

            #region Conditions
            Console.WriteLine("\n--- Conditions ---");
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            #endregion

            #region Switch
            Console.WriteLine("\n--- Switch ---");
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            #endregion

            #region While Loop
            Console.WriteLine("\n--- While Loop ---");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);

            #endregion

            #region For Loop
            Console.WriteLine("\n--- For Loop ---");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }

            #endregion

            #region Method Parameter
            Console.WriteLine("\n--- Method Parameter ---");
            MyMethod();
            #endregion

            #region Method Overloading
            Console.WriteLine("\n--- Method Overloading ---");
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
            #endregion

            #region Class Member
            Console.WriteLine("\n--- Class Member ---");
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Ford.FullThrottle();

            #endregion

            #region Inheritence
            Console.WriteLine("\n--- Inheritence ---");

            Car myCar = new Car();
            myCar.Honk();
            Console.WriteLine(myCar.brand + " " + myCar.model);

            #endregion

            #region Polymorphism
            Console.WriteLine("\n--- Polymorphism ---");

            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();

            #endregion

            #region Abstraction
            Console.WriteLine("\n--- Abstraction ---");

            Cow myCow = new Cow();
            myCow.AnimalSound();
            myCow.Sleep();

            #endregion

            #region Interface
            Console.WriteLine("\n--- Interface ---");

            Cat myCat = new Cat();
            myCat.AnimalSound();

            DemoClass demoClass = new DemoClass();
            demoClass.MyMethod();
            demoClass.MyOtherMethod();

            #endregion

            #region Enum
            Console.WriteLine("\n--- Enum ---");

            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);
            Console.WriteLine(Level.High);

            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            myNum = (int)Months.June;
            Console.WriteLine(myNum);

            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;

                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;

                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

            #endregion

            #region File
            Console.WriteLine("\n--- File ---");

            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);

            #endregion

            #region Exception
            Console.WriteLine("\n--- Exception ---");

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            CheckAge(21);
            #endregion

            #region Add Two Numbers
            Console.WriteLine("\n--- Add Two Numbers ---");

            int m = 5;
            int n = 6;
            int sum = m + n;
            Console.WriteLine(sum);

            #endregion
        }

        static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - you are old enough!");
            }
        }
    }

    #region Inheritence
    class Vehicle
    {
        public string brand = "Ford";
        public void Honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle
    {
        public string model = "Mustang";
        public string color;
        public int year;

        public void FullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    #endregion

    #region Polymorphism
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says wee wee");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says bow wow");
        }
    }
    #endregion

    #region Abstraction
    abstract class AAnimal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Cow : AAnimal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The cow says moo moo");
        }
    }
    #endregion

    #region Interface
    interface IAnimal
    {
        void AnimalSound();
    }

    class Cat : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Cat says meow meow");
        }
    }

    interface IFirstInterface
    {
        void MyMethod();
    }

    interface ISecondInterface
    {
        void MyOtherMethod();
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text...");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    #endregion

    #region Enum
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May = 6,    // 6
        June,       // 7
        July        // 8
    }
    #endregion
}
