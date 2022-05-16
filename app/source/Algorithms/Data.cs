namespace Karamath.Algorithms {

    public static class Data {

        /// <summary>
        ///     Finds the given number in array with help of linear search
        /// </summary>
        /// 
        /// <param name="arr">
        ///     An array of 32-bit integer values representing an array on which function will work
        /// </param>
        /// <param name="res">
        ///     A 32-bit integer value representing the element to find in the array
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing the position of element in array that suits the case
        /// </returns>
        /// 
        public static int FinderLIN(int[] arr, int res) {
            
            int k = -1,
                counter = 0;

            int length = arr.Length;

            for(int i = 0; i < length; i++) {

                counter++;

                if(arr[i] == res) {
                    k = i;
                    break;
                }
            }

            return k;
        }
        
        /// <summary>
        ///     Finds the given number in array with help of binary search
        /// </summary>
        /// 
        /// <param name="arr">
        ///     An array of 32-bit integer values representing an array on which function will work
        /// </param>
        /// <param name="res">
        ///     A 32-bit integer value representing the element to find in the array
        /// </param>
        /// 
        /// <returns>
        ///     A 32-bit integer value representing the position of element in array that suits the case
        /// </returns>
        /// 
        public static int FinderBIN(int[] arr, int res) {
            
            int length = arr.Length;
            int counter = 0;

            int L = 0,
                R = length - 1;
                

            int k = (R + L) / 2;

            while(L < R - 1) {

                counter++;

                k = (R + L) / 2;

                if(arr[k] == res)
                    return k;

                counter++;

                if(arr[k] < res)
                    L = k;
                else
                    R = k;
            }

            if(arr[k] != res) {

                if(arr[L] == res)
                    k = L;
                else {

                    if(arr[R] == res)
                        k = R;
                    else
                        k = -1;
                }
            }

            return k;
        }
    }
}