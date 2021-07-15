using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalWorld
{
    class Frog : IAnimal, IShowAnimal
    {
        private List<Animal> list { get; set; }
        public void Info()
        {
            var objectData = new ObjectData();
            list = objectData.animallist;
            var selectanimal = from g in list
                               where g.Name == "Frog"
                               select g;
            foreach (var frog in selectanimal)
                Console.WriteLine($"Name:     {frog.Name}\n" +
                                  $"Quantity: {frog.Quantity}\n" +
                                  $"Color:    {frog.Color}\n" +
                                  $"Food:     {frog.Food}");
        }

        public void Sleep()
        {
            Console.WriteLine("Frog sleep in the winter");
        }

        public void Walk()
        {
            Console.WriteLine("Frogs can walk at night");
        }


        public void Show()
        {
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}