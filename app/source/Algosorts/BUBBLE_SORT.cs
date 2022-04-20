namespace MathFX
{

    public static class BUBBLE_SORT
    {
        public static int[] B_SORT(int[] arr)
        {
            bool tag = true;

            int adjuster, 
                length = arr.Length;

            for(int i = 1;((i <= (length - 1)) && tag); i++)
            {
                tag = false;

                for(int j = 0; j < length - 1; j++)
                {
                    if(arr[j + 1] > arr[j])
                    {
                        adjuster = arr[j];

                        arr[j] = arr[j + 1];
                        arr[j + 1] = adjuster;

                        tag = true;
                    }
                }
            }

            return arr;
        }
    }
}
