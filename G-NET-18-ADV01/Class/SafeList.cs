using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_ADV01.Class
{
    public class SafeList<T>
    {
        private readonly List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T GetValue(int index)
        {
            if (index < 0 || index >= list.Count)
                return default(T);

            return list[index];
        }
    }
}
