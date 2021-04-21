using System;

namespace CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            String A = "ABC";
            String B = "ABC";
            int result = 0;

            result = String.Compare(A, B);
            Console.WriteLine(+result);
            
        }
    }
}
