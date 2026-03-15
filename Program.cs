using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace G_Net_40_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // generics allow you to define type-safe classes, interfaces, methods, and delegates without committing to a specifiec data type  until the code is used
            //we use genrics because it make Type Safety and better	Performance make Codes reusable and maintainable
            #endregion
            #region Question 2
            // public class container<T> {
            //  private T item;
            //public void Add(T value)
            //    {
            //        item = value;
            //    }
            //         public T Get()
            //    {
            //        return item;
            //    }
            #endregion
            #region Question 3
            //it is  Generic classes that can have multiple type parameters
            //    public class pair <T1 , T2>
            //{
            //    public T1 Tfirst {  get; set; }
            //    public T2 Tsecond { get; set; }

            //    public Pair(TFirst first, TSecond second)
            //    {
            //        First = first;
            //        Second = second;
            //    }
            //}
            #endregion
            #region Question 4
            //A generic method declares its own type parameter(s) It can exist in both generic and non-generic classes The compiler often infers the type argument
            //public void swap<T> (ref  T x, ref T y) {
            //  T temp = x;
            //  x= y;
            //  y= temp;
            //}

            #endregion
            #region Question 5
            //    public static T FindMax<T>(T a, T b) where T : IComparable<T>
            //{
            //    if (a.CompareTo(b) > 0)
            //        return a;
            //    else
            //        return b;
            //}
            #endregion
            #region Question 6
            //    public interface IRepository<T> where T : class
            //{
            //    T? GetById(int id);
            //    IEnumerable<T> GetAll();
            //    void Add(T entity);
            //    void Update(T entity);

            //}
            #endregion
            #region Question 7
            //    public class Example<T> where T : struct
            //{
            //    public T Value { get; set; }
            //}
            #endregion
            #region Question 8
            //    public class expermint<T> where T : class
            //{
            //    public T Data { get; set; }
            //}
            #endregion
            #region question 9
            //    public class Factory<T> where T : new()
            //{
            //    public T Create()
            //    {
            //        return new T();
            //    }
            //}
            #endregion
            #region Question 10
        //    public class Printer<T> where T : IComparable<T>
        //{
        //    public T Max(T a, T b)
        //    {
        //        return a.CompareTo(b) > 0 ? a : b;
        //    }
        }
            #endregion
        #region Question 11
        //public class Animal
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("Animal sound");
        //    }
        //}
        //public class cat<T> where T : Animal
        //{
        //    public void MakeSound(T animal)
        //    {
        //        animal.Speak();
        //    }
        //}
        #endregion
        #region Question 12
        //    public class Repository<T>
        //where T : class, IComparable<T>, new()
        //    {
        //        public T Create()
        //        {
        //            return new T();
        //        }
        //    }
        #endregion
        #region Question 13
        //public T GetDefault<T>()
        //{
        //    return default(T);
        //}
        #endregion
        #region Question 14
        //public class safeList<T>
        //    {
        //   private List<T> items = new List<T>();
        //   public void Add(T item)
        //    {
        //        items.Add(item);
        //     }

        //   public T Get(int index)
        //        {
        //            if (index >= 0 && index < items.Count)
        //                return items[index];
        //  return default(T);
        //       }
        //    }
        #endregion
        #region Question 15 
        // Covariance allows you to use a more derived type than originally specified Marked with out keyword
        // OUT MEAN  can only appear in output positions
        #endregion
        #region Question 16
        //Contravariance allows you to use a less derived type than originally specified Marked with in keyword
        //IN mean T can only appear in input positions
        #endregion
        #region Question 17
        //      Covariance(out) is used for return values and allows conversion from derived type to base type
        //Contravariance(in) is used for method parameters and allows conversion from base type to derived type
        #endregion
        #region Question 18 
        //Each closed generic type has its own copy of static fields.List<int> and List<string> have separate static data
        #endregion
    }
}
    }









