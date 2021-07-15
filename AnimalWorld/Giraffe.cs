using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalWorld
{
    class Giraffe : IAnimal, IShowAnimal
    {
        private List<Animal> list { get; set; }
        public void Info()
        {
            var objectData = new ObjectData();
            list = objectData.animallist;
            var selectanimal = from g in list
                               where g.Name == "Giraffe"
                               select g;
            foreach(var giraffe in selectanimal)
                Console.WriteLine($"Name:     {giraffe.Name}\n" +
                                  $"Height    {giraffe.Height}" +
                                  $"Quantity: {giraffe.Quantity}\n" +
                                  $"Color:    {giraffe.Color}\n" +
                                  $"Food:     {giraffe.Food}");
        }

        public void Sleep()
        {
            Console.WriteLine("Giraffe sleep at night");
        }

        public void Walk()
        {
            Console.WriteLine("Giraffe walk at daytime");
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