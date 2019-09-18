using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab1._4
{/*
     public class Farm
    {
        public abstract class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating...");
            }

        }
        public class Dog : Animal
        {

            public void Bark()
            {
                Console.WriteLine("Barking...");
            }


        }
        //public class Puppy : Dog
        //{
        //    public void Weep()
        //    {
        //        Console.WriteLine("weeping...");
        //    }
        //}
        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("Meuw...");
            }
        }
    }
   
    class Program
    {
        public void menu()
        {
            Console.WriteLine("Wellcome to my Farm");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Come back late");

        }
        static void Main(string[] args)
        {
            Program myFarm = new Program();
            myFarm.menu();
            Console.Write("Enter your command: ");
            int cmenu = Convert.ToInt32(Console.ReadLine());
            
            while (cmenu != 3)
            {
                if (cmenu > 3 || cmenu < 0)
                {
                    Console.WriteLine("Invalid command");
                    break;

                }
                else
                {
                    switch (cmenu)
                    {
                        case 1:
                            Farm.Dog dog = new Farm.Dog();
                            dog.Eat();
                            dog.Bark();
                            break;
                        case 2:
                            Farm.Cat cat = new Farm.Cat();
                            cat.Eat();
                            cat.Meow();
                            break;
                        case 3:                           
                            break;                      
                        default:
                            break;
                    }
                    if (cmenu == 3) break;
                    
                }
                Console.Write("Enter your command: ");
                cmenu = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Goodbye!");
            Console.Read();


                   
            
        }
    }*/
    public class CustomStack
    {

    }

}
