using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -3, 2, 4, 10, 12, 14, 17, 18, 20, 25, 36, 78, 100, 110 };    // (n) elements
            int target = 78;

            int targetIndex = BinarySearch.SearchUsingRecursion(array, target, 0, array.Length - 1);
            Console.WriteLine($"result of binary search using recursion : {targetIndex}");

            targetIndex = BinarySearch.SearchUsingWhileLoop(array, target);
            Console.WriteLine($"result of binary search using while loop : {targetIndex}");
        }
    }
}
