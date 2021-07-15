using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AnimalWorld
{
    class Gibbon : IAnimal, IShowAnimal
    {

        private readonly string PATH;

        public Gibbon(string path)
        {
            PATH = path;
        }

        private string Name { get; set; }
        private string Lifespan { get; set; }
        private string Weight { get; set; }
        private string Quantity { get; set; }
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
                              where xe.Attribute("name").Value == "Gibbon"
                              select new Gibbon(PATH)
                              {
                                  Name = xe.Attribute("name").Value,
                                  Weight = xe.Element("weight").Value,
                                  Quantity = xe.Element("quantity").Value,
                                  Lifespan = xe.Element("lifespan").Value,
                                  Color = xe.Element("color").Value,
                                  Food = xe.Element("food").Value,
                              };

                foreach (var gibbon in animals)
                    Console.WriteLine($"Name:     {gibbon.Name}\n" +
                                      $"Weight:   {gibbon.Weight}\n" +
                                      $"Quantity: {gibbon.Quantity}\n" +
                                      $"Lifespan: {gibbon.Lifespan}\n" +
                                      $"Color:    {gibbon.Color}\n" +
                                      $"Food:     {gibbon.Food}");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Gibbons are sleep on trees");
        }

        public void Walk()
        {
            Console.WriteLine("Gibbons start walk at 10am");
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