using System;
using System.Collections.Generic;

namespace Week2._0
{
    class Pet
    {
        private string name;
        private string owner;
        private int age;
        private string description;
        private bool isHouseTrained;

        public Pet(string name, string owner, int age, string description, bool isHouseTrained)
        {
            this.name = name;
            this.owner = "no one";
            this.age = age;
            this.description = description;
            this.isHouseTrained = true;
        }
        public override string ToString()
        {
            return string.Format("My name is {0}. My owner is {1} and I am {2} years old. I am {3}. House trained: {4}\n", name, owner, age, description, isHouseTrained);
        }
        public void SetOwner(string NewOwner)
        {
            owner = NewOwner;
        }
        public void GetOwner(string Owner)
        {
            
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            //create a list to store pets
            List<Pet> pets = new List<Pet>();
            //instantaite the class
            Pet p1 = new Pet("Max", "owner", 5, "The Best Dog NA", true);
            //Console.WriteLine(p1);
            p1.SetOwner("James Li");
            // Console.WriteLine(p1);
            pets.Add(p1);

            p1 = new Pet("Snow", "owner", 2, "fat and fluffy", true);
            //Console.WriteLine(p1);
            p1.SetOwner("Kevin Yang");
            Console.WriteLine(p1);
            pets.Add(p1);
            foreach (Pet pet in pets)
            {
                if (item.getOwner() == "James Li")
                {
                    Console.WriteLine(pet);
                }
            }
        }
    }

}
