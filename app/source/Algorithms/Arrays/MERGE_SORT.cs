namespace MathFX.Algorithms
{

    public static class MERGE_SORT
    {

        public static int[] SORT(int[] arr)
        {
            int[] lft,
                  rgt;

            int middle = arr.Length / 2;

            lft = new int[middle];

            if(arr.Length % 2 == 0)
                rgt = new int[middle];

            else
                rgt = new int[middle + 1];

            for(int i = 0; i < middle; i++)
                lft[i] = arr[i];

            int X = 0;

            for(int i = middle; i < arr.Length; i++)
            {
                rgt[X] = arr[i];
                X++;
            }

            lft = SORT(lft);
            rgt = SORT(rgt);

            int[] res = MERGE(lft, rgt);

            return res;
        }

        private static int[] MERGE(int[] lft, int[] rgt)
        {
            int length = rgt.Length + lft.Length;

            int[] res = new int[length];

            int lftIndex = 0,
                rgtIndex = 0,
                resIndex = 0;

            while(lftIndex < lft.Length || rgtIndex < rgt.Length)
            {
                if(lftIndex < lft.Length && rgtIndex < rgt.Length)
                {
                    if(lft[lftIndex] <= rgt[rgtIndex])
                    {
                        res[resIndex] = lft[lftIndex];

                        lftIndex++;
                        resIndex++;
                    }
                    else
                    {
                        res[resIndex] = rgt[rgtIndex];

                        rgtIndex++;
                        resIndex++;
                    }
                }
                else if(lftIndex < lft.Length)
                {
                    res[resIndex] = lft[lftIndex];

                    lftIndex++;
                    resIndex++;
                }
                else if(rgtIndex < rgt.Length)
                {
                    res[resIndex] = rgt[rgtIndex];

                    rgtIndex++;
                    resIndex++;
                }
            }

            return res;
        }
    }
}
