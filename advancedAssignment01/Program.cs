namespace advancedAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //works with different data types without the exact type, we use the type parameter (T) as a placeholder for a data type
            #endregion

            string s1 = "Hello", s2 = "World";
            Swap(ref s1, ref s2);
            Console.WriteLine(s1, s2);

            Console.WriteLine(FindMax<int>(10, 20));

        }

        #region Q4

        //What is a generic method? method that uses a type parameter, so it works with diff data types without diff methods

        static void Swap<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }

        #endregion

        #region Q5

        static T FindMax<T>(T a, T b) where T : IComparable<T>{
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }

        #endregion
    }
}
