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
    }
    }
    }









