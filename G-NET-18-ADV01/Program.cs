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
            //Container<int> number = new(10);
            #endregion


            #region Question03
            /*What are multiple type parameters? Write Pair<TKey, TValue>.*/
            //Pair<string, int> pair = new("key", 10);
            #endregion


            #region Question04
            /*What is a generic method? Write Swap<T> method.*/
            //int x = 5 ,y = 10;
            //Swap<int>(ref x ,ref y);
            //Console.WriteLine($"{x} {y}");
            #endregion


            #region Question05
            /*Write a generic method FindMax<T> that finds maximum value*/
            //int x = 11, y = 10;
            //Console.WriteLine(FindMax(x, y));
            #endregion


            #region Question06
            /*Q6: What is a generic interface? Write IRepository<T>. */

            #endregion


            #region Question07
            /*Q7: What is the 'struct' constraint? Write an example.
             * Restricts T to value types only.
             */
            //ValueContainer<int> number = new();
            #endregion
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }


        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
