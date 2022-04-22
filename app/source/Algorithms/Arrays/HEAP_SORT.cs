namespace MathFX
{

    public static class HEAP_SORT
    {

        public static int[] SORT(int[] arr)
        {
            int heaps = arr.Length;

            for(int i = heaps / 2 - 1; i >= 0; i--)
            {
                HEAPIFY(arr, heaps, i);
            }

            for(int i = heaps - 1; i >= 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);

                HEAPIFY(arr, i, 0);
            }

            return arr;
        }

        private static void HEAPIFY(int[] arr, int heaps, int Q)
        {
            int LG = Q;

            int lft = 2 * Q + 1;
            int rgt = 2 * Q + 2;

            if(lft < heaps && arr[lft] > arr[LG])
                LG = lft;

            if(rgt < heaps && arr[rgt] > arr[LG])
                LG = rgt;

            if(LG != Q)
            {
                (arr[LG], arr[Q]) = (arr[Q], arr[LG]);

                HEAPIFY(arr, heaps, LG);
            }
        }
    }
}
