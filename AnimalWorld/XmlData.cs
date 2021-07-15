using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AnimalWorld
{
    class XmlData
    {
        private readonly string PATH;

        public XmlData(string path)
        {
            PATH = path;
        }
        public void CreateXML()
        {
            XDocument xdoc = new XDocument(new XElement("animals",
                new XElement("animal",
                    new XAttribute("name", "Elefant"),
                    new XElement("weight", "40000"),
                    new XElement("quantity", "4"),
                    new XElement("lifespan", "75"),
                    new XElement("color", "gray"),
                    new XElement("food", "grass"),
                    new XElement("type", "african")),
                new XElement("animal",
                    new XAttribute("name", "Gibbon"),
                    new XElement("lifespan", "40"),
                    new XElement("weight", "7"),
                    new XElement("quantity", "3"),
                    new XElement("food", "fruits"),
                    new XElement("color", "dark brown")),
                new XElement("animal",
                    new XAttribute("name","Monkey"),
                    new XElement("quantity", "4"),
                    new XElement("lifespan", "40"),
                    new XElement("growth", "1"),
                    new XElement("food", "bananas"),
                    new XElement("color", "broun"))));
            xdoc.Save(PATH);
        }
    }
}
