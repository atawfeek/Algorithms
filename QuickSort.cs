namespace algorithm
{
    public static class QuickSort
    {
        public static void ExecuteQuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int minIndex, int MaxIndex)
        {
            if (minIndex < MaxIndex)
            {
                int pivotIndex = PartitionPiovot(array, minIndex, MaxIndex);

                Sort(array, minIndex, pivotIndex - 1);
                Sort(array, pivotIndex + 1, MaxIndex);
            }
        }

        private static int PartitionPiovot(int[] array, int minIndex, int MaxIndex)
        {
            int pivot = array[MaxIndex];   // choose pivot the last element as pattern.

            int indexOfSmaller = minIndex - 1;

            for(int J = minIndex; J <= MaxIndex - 1; J++)
            {
                if(array[J] < pivot)
                {
                    indexOfSmaller++;
                    SwapElements(array, indexOfSmaller, J);
                }
            }

            SwapElements(array, indexOfSmaller + 1, MaxIndex);

            return indexOfSmaller + 1; // final pivot index
        }

        private static void SwapElements(int[] array, int indexOfFirst, int indexOfSecond)
        {
            int temp = array[indexOfFirst];
            array[indexOfFirst] = array[indexOfSecond];
            array[indexOfSecond] = temp;
        }
    }
}
