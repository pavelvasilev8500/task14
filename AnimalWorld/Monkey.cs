using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AnimalWorld
{
    class Monkey : IAnimal, IShowAnimal
    {

        private readonly string PATH;

        public Monkey(string path)
        {
            PATH = path;
        }

        private string Name { get; set; }
        private string Quantity { get; set; }
        private string Lifespan { get; set; }
        private string Growth { get; set; }
        private string Food { get; set; }
        private string Color { get; set; }
        public void Info()
        {
            var fileExists = File.Exists(PATH);
            if (!fileExists)
            {
                Console.WriteLine("No file for input data.");
            }
            else
            {
                XDocument xdoc = XDocument.Load(PATH);
                var animals = from xe in xdoc.Element("animals").Elements("animal")
                              where xe.Attribute("name").Value == "Monkey"
                              select new Monkey(PATH)
                              {
                                  Name = xe.Attribute("name").Value,
                                  Quantity = xe.Element("quantity").Value,
                                  Lifespan = xe.Element("lifespan").Value,
                                  Color = xe.Element("color").Value,
                                  Food = xe.Element("food").Value,
                              };

                foreach (var monkey in animals)
                    Console.WriteLine($"Name:     {monkey.Name}\n" +
                                      $"Quantity: {monkey.Quantity}\n" +
                                      $"Lifespan: {monkey.Lifespan}\n" +
                                      $"Color:    {monkey.Color}\n" +
                                      $"Food:     {monkey.Food}");
            }
        }

        public void Sleep()
        {
                Console.WriteLine("At 12pm monkeys are alrady sleep;");
        }

        public void Walk()
        {
                Console.WriteLine("At 1pm Monkeys are walking;");
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