using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class ObjectData
    {
        public List<Animal> animallist = new List<Animal>()
        {
            new Animal{Name = "Giraffe", Height = "5", Quantity = "2", Color = "orange-yellow", Food = "acacia"},
            new Animal{Name = "Frog", Quantity = "10", Color = "green", Food = "insects"},
            new Animal{Name = "Salamander", Quantity = "3", Color = "bright orange", Food = "Invertebrates" }
        };
    }
}
