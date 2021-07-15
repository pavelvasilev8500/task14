using System.Collections.Generic;

namespace AnimalWorld
{
    class Group 
    {
        private string PATH;

        public Group(string path)
        {
            PATH = path;
        }

        private void Animals()
        {
            var alist = new List<IShowAnimal>();
            alist.Add(new Monkey(PATH));
            alist.Add(new Gibbon(PATH));
            alist.Add(new Elephant(PATH));
            alist.Add(new Giraffe());
            alist.Add(new Frog());
            alist.Add(new Salamander());
            foreach(IShowAnimal animal in alist)
            {
                animal.Show();
            }
        }

        public void Show()
        {
            Animals();
        }
    }
}