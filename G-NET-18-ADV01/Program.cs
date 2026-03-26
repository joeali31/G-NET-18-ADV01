using G_NET_18_ADV01.Class;
using System.ComponentModel;

namespace G_NET_18_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            /*Q1: What is a generic class? Why use generics?
             * What is a generic : A generic class is a class that can work with any data type using a type parameter
             * Why use generics : No boxing/unboxing , Type safety , Reusability
             */
            #endregion


            #region Question02
            /*Write a generic class Container<T> with Add and Get methods.*/
            Container<int> number = new(10);
            #endregion

        }
    }
}
