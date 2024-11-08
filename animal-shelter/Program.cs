using System.Collections.Generic;


namespace animal_shelter
{



    internal class Program
    {
        
        

        //the dog class or the general pet class 
        class Pet
        {
            public int age;
            public string name;
            public string breed;

            //Pet constructor
           

        }

        //the person class 
        class Person()
        {
            public int age;
            public string name;

            //person constructor
          

        }

        //Making an empty dictionary wiht the name as the key to the Pet object
        Dictionary<string, object> animalList = new Dictionary<string, object>();

        void add(string name, Pet pet) {
            animalList.Add(name, pet);
        
        }

        void remove(string name) { 
            animalList.Remove(name);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
