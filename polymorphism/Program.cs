using System;
namespace polymorphism
{
     class Animal
    {
         public virtual  void animalSound()
        {
           Console.WriteLine("the animal sound");
        }
    }
    class dog : Animal
    {
        public override  void animalSound()
        {
            Console.WriteLine("bow bow");
        }
    }
     class cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("meow meow");

        }
    } 
     class program
    {
        static void Main(string[] args)
        {
            Animal myanimal = new Animal();
            Animal mydog = new dog();
            Animal mycat = new cat();
            myanimal.animalSound();
            mydog.animalSound();
            mycat.animalSound();
        }
    }
 }
