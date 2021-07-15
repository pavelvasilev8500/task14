using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalWorld
{
    class Salamander : IAnimal, IShowAnimal
    {
        private List<Animal> list { get; set; }
        public void Info()
        {
            var objectData = new ObjectData();
            list = objectData.animallist;
            var selectanimal = from g in list
                               where g.Name == "Salamander"
                               select g;
            foreach (var salamander in selectanimal)
                Console.WriteLine($"Name:     {salamander.Name}\n" +
                                  $"Quantity: {salamander.Quantity}\n" +
                                  $"Color:    {salamander.Color}\n" +
                                  $"Food:     {salamander.Food}");
        }

        public void Sleep()
        {
            Console.WriteLine("Salamanders does'n sleep at night");
        }

        public void Walk()
        {
            Console.WriteLine("Salamanders walk in the mountains");
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