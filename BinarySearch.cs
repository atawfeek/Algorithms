namespace algorithm
{
    public static class BinarySearch
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <param name="minIndex"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        public static int SearchUsingRecursion(int[] array, int target, int minIndex, int maxIndex)
        {
            if (array[minIndex] == target)
                return minIndex;

            if(array[maxIndex] == target)
                return maxIndex;

            if (minIndex == maxIndex - 1)
                return -1;

            int midIndex = (maxIndex + minIndex) / 2;

            if (array[midIndex] == target)
                return midIndex;

            if (array[midIndex] > target)
                return SearchUsingRecursion(array, target, minIndex, midIndex);
            else            
                return SearchUsingRecursion(array, target, midIndex, maxIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchUsingWhileLoop(int[] array, int target)
        {
            // Your code here
            int minIndex = 0;
            int maxIndex = array.Length - 1;

            while (minIndex < maxIndex)
            {
                if (array[minIndex] == target)
                    return minIndex;

                if (array[maxIndex] == target)
                    return maxIndex;

                if (maxIndex == minIndex + 1)
                    return -1;

                int midIndex = (minIndex + maxIndex) / 2;

                if (array[midIndex] == target)
                {
                    return midIndex;
                }

                if (array[midIndex] > target)
                {
                    maxIndex = midIndex - 1;
                }

                if (array[midIndex] < target)
                {
                    minIndex = midIndex + 1;
                }

            }

            return -1;
        }
    }
}


