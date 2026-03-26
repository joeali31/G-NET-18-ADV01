using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_ADV01.Class
{
    public class Container<T>
    {
        private T _item;

        public Container(T item)
        {
            _item = item;
        }

        public void Add(T item)
        {
            _item = item;
        }

        public T Get()
        {
            return _item;
        }
    }
}
