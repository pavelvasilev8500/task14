using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AnimalWorld
{
    class Animals
    {
        private static string PATH = $"{Environment.CurrentDirectory}\\animals.xml";

        private void Xml()
        {
            var xmlDate = new XmlData(PATH);
            xmlDate.CreateXML();
        }

        public void Method()
        {
            Xml();
            var group = new Group(PATH);
            group.Show();
        }
    }
}
