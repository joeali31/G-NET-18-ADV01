using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_ADV01.Class
{
    public class Animal
    {
        public void Speak() { }
    }

    public class ContainerAnimal<T> where T : Animal 
    {
        public T Item { get; set; }

        public void CallSpeak()
        {
            Item.Speak();
        }
    }
}
