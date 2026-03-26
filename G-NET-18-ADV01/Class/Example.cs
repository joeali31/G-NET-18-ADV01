using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_ADV01.Class
{
    public class Example<T> where T : class , IComparable , new()
    {
        public T value { get; set; }
    }
}
