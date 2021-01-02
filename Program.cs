using System;
using System.Linq;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Search
            int[] arrayToSearch = { -3, 2, 4, 10, 12, 14, 17, 18, 20, 25, 36, 78, 100, 110 };    // (n) elements
            int target = 78;

            int targetIndex = BinarySearch.SearchUsingRecursion(arrayToSearch, target, 0, arrayToSearch.Length - 1);
            Console.WriteLine($"result of binary search using recursion : {targetIndex}");

            targetIndex = BinarySearch.SearchUsingWhileLoop(arrayToSearch, target);
            Console.WriteLine($"result of binary search using while loop : {targetIndex}");
            #endregion

            #region Sort
            int[] arrayToSort = { -3, 2, 4, 1, 12, 10, 9, 6, 20, 25, 24, 78, 100, 50 };    // (n) elements
            QuickSort.ExecuteQuickSort(arrayToSort);
            Console.WriteLine($"result of quick sort is :");
            arrayToSort.ToList().ForEach(x => Console.Write($"{x} "));
            #endregion
        }
    }
}
