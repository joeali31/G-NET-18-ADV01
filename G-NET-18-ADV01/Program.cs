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


            #region Question08
            /*Q8: What is the 'class' constraint? Write an example.
             * Restricts T to reference types only.
             */
            //ValueContainer<string> container = new ValueContainer<string>();
            #endregion


            #region Question09
            /*Q9: What is the 'new()' constraint? Write an example.
             * Requires that T has a parameterless constructor.
             */
            #endregion


            #region Question10
            /*Q10:  What is the interface constraint? Write an example.
             * Restricts T to types that implement a specific interface.
             */
            #endregion


            #region Question11
            /*Q11: What is the base class constraint? Write an example.
             * Restricts T to inherit from a specific base class.
             */
            #endregion


            #region Question12
            /*Q12: How do you apply multiple constraints? Write an example. 
             * You can combine constraints using commas.
             */


            #endregion


            #region Question13
            /*Q13: What does the default keyword do in generics?
             * default returns the default value of a type
             */
            #endregion


            #region Question14
            /* Write a SafeList<T> that returns default when the index is invalid.*/
            #endregion


            #region Question15
            /*Q15: What is covariance? Explain the 'out' keyword.
             * Covariance allows a more derived type to be used where a base type is expected.
             */
            #endregion


            #region Question16
            /*What is contravariance? Explain the 'in' keyword.
             * Contravariance allows a less derived type to be used where a more derived type is expected.
             */
            #endregion


            #region Question17
            /*Q17: What is the difference between covariance and contravariance?
             * Covariance : Derived → Base , Output , out , IEnumerable<out T>
             * Contravariance : Base → Derived , Input , in , IEnumerable<in T>
             */
            #endregion


            #region Question18
            /*Q18: How do static members work in generic types?
             * Static members are shared per closed generic type, not across all types.
             */
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
