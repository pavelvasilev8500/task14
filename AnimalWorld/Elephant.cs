using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace AnimalWorld
{
    class Elephant : IAnimal, IShowAnimal
    {

        private readonly string PATH;

        public Elephant(string path)
        {
            PATH = path;
        }

        private string Name { get; set; }
        private string Weight { get; set; } 
        private string Quantity { get; set; }
        private string Lifespan { get; set; }
        private string Color { get; set; }
        private string Food { get; set; }
        private string Type { get; set; }

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
                            where xe.Attribute("name").Value == "Elefant"
                            select new Elephant(PATH)
                            {
                                Name =     xe.Attribute("name").Value,
                                Weight =   xe.Element("weight").Value,
                                Quantity = xe.Element("quantity").Value,
                                Lifespan = xe.Element("lifespan").Value,
                                Color =    xe.Element("color").Value,
                                Food =     xe.Element("food").Value,
                                Type =     xe.Element("type").Value
                            };

                foreach (var elefant in animals)
                    Console.WriteLine($"Name:     {elefant.Name}\n" +
                                      $"Weight:   {elefant.Weight}\n" +
                                      $"Quantity: {elefant.Quantity}\n" +
                                      $"Lifespan: {elefant.Lifespan}\n" +
                                      $"Color:    {elefant.Color}\n" +
                                      $"Food:     {elefant.Food}\n" +
                                      $"Type:     {elefant.Type}");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Elefants are redy to sleep at 10pm;");
        }

        public void Walk()
        {
            Console.WriteLine("Elefants are walking;");
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