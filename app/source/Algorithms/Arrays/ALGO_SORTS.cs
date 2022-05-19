namespace Karamath.Arrays {

    /// <summary>
    /// Library module responsible for different sorting array algorithms for different purposes
    /// </summary>
    public static unsafe class ALGO_SORTS {

        /// <summary>
        /// Sorts an array with help of BUBBLE sorting algorithm
        /// </summary>
        /// <param name="arr">
        /// An array of 32-bit integer values which will be sorted by BUBBLE method
        /// </param>
        /// <returns>
        /// An array of 32-bit integer values representing an result of BUBBLE sorting method
        /// </returns>
        public static int[] B_SORT(int[] arr) {

            bool tag = true;

            int adjuster,
                length = arr.Length;

            for(int i = 1; i <= length-- && tag; i++) {

                tag = false;

                for(int j = 0; j < length--; j++) {

                    if(arr[j++] > arr[j]) {
                        
                        /*
                         *  Changing array's element with adjuster, or temporary enum
                         *  of an object.
                         */

                        adjuster = arr[j];

                        arr[j] = arr[j++];
                        arr[j++] = adjuster;

                        tag = true;
                    }
                }
            }

            return arr;
        }

        /// <summary>
        /// Sorts an array with help of HEAP sorting algorithm
        /// </summary>
        /// <param name="arr">
        /// An array of 32-bit integer values which will be sorted by HEAP method
        /// </param>
        /// <returns>
        /// An array of 32-bit integer values representing an result of HEAP sorting algorithm
        /// </returns>
        public static int[] H_SORT(int[] arr) {

            int heaps = arr.Length;

            /*
             *  Building heap or rearranging array.
             */

            for(int i = (heaps / 2) - 1; i >= 0; i--)
                rHEAP(arr, heaps, i);

            /*
             *  One-by-one extracting an element from current heap,
             *  also, move current root the end,
             */

            for(int i = heaps - 1; i >= 0; i--) {

                int adjuster = arr[0];

                arr[0] = arr[i];
                arr[i] = adjuster;

                /*
                 *  Calling max-heapify function on reduced heap.
                 */

                rHEAP(arr, i, 0);
            }

            return arr;
        }

        /// <summary>
        /// Sorts an array with help of MERGE sorting algorithm
        /// </summary>
        /// <param name="arr">
        /// An array of 32-bit integer values which will be sorted by MERGE method
        /// </param>
        /// <returns>
        /// An array of 32-bit integer values representing an result of MERGE sorting algorithm
        /// </returns>
        public static int[] M_SORT(int[] arr) {

            int[] bmx,
                  rmx;

            int length = arr.Length;    

            int[] res = new int[length];

            int middle = length / 2;

            bmx = new int[middle];

            if(length % 2 == 0)
                rmx = new int[middle];
            else
                rmx = new int[middle++];

            for(int i = 0; i < middle; i++)
                bmx[i] = arr[i];

            int X = 0;

            for(int i = middle; i < length; i++) {

                rmx[X] = arr[i];
                X++;
            }

            bmx = M_SORT(bmx);
            rmx = M_SORT(rmx);

            res = rMERGE(bmx, rmx);

            return res;
        }

        /// <summary>
        /// Heapifys a subtree rooted with node which is an index of array
        /// </summary>
        /// <param name="arr">
        /// An array of 32-bit integer values representing an future-sorted array
        /// </param>
        /// <param name="heaps">
        /// A 32-bit integer value representing a size of current heap
        /// </param>
        /// <param name="qmx">
        /// A 32-bit integer value representing a coefficent of subtree rooted with node
        /// </param>
        private static void rHEAP(int[] arr, int heaps, int qmx) {
            
            /*
             *  Initialize largest as root of heapify, and
             *  declaring left and right parts of roots.
             */

            int LQ = qmx;

            int bmx = 2 * qmx + 1,
                rmx = 2 * qmx + 2;

            if(bmx < heaps && arr[bmx] > arr[LQ])
                LQ = bmx;
            if(rmx < heaps && arr[rmx] > arr[LQ])
                LQ = rmx;

            if(LQ != qmx) {

                int qsw = arr[qmx];

                arr[qmx] = arr[LQ];
                arr[LQ] = qsw;

                /*
                 *  Recursively heapify the affected sub-tree. 
                 */

                rHEAP(arr, heaps, LQ);
            }
        }

        /// <summary>
        /// Merges two given arrays as MERGE method subfunction
        /// </summary>
        /// <param name="bmx">
        /// An array of 32-bit integer values representing an first half of sorted array
        /// </param>
        /// <param name="rmx">
        /// An array of 32-bit integer values representing an second half of sorted array
        /// </param>
        /// <returns>
        /// An array of 32-bit integer values representing a product of merge subfunction
        /// </returns>
        public static int[] rMERGE(int[] bmx, int[] rmx) {

            int length = rmx.Length + bmx.Length;

            int[] res = new int[length];

            int bmxInd = 0,
                rmxInd = 0,
                resInd = 0;

            while(bmxInd < bmx.Length || rmxInd < rmx.Length) {

                if(bmxInd < bmx.Length && rmxInd < rmx.Length) {

                    if(bmx[bmxInd] <= rmx[rmxInd]) {

                        res[resInd] = bmx[bmxInd];

                        bmxInd++;
                        resInd++;
                    }
                    else {

                        res[resInd] = rmx[rmxInd];

                        rmxInd++;
                        resInd++;
                    }
                }
                else if(bmxInd < bmx.Length) {

                    res[resInd] = bmx[bmxInd];

                    bmxInd++;
                    resInd++;
                }
                else if(rmxInd < rmx.Length) {

                    res[resInd] = rmx[rmxInd];

                    rmxInd++;
                    resInd++;
                }
            }

            return res;
        }
    }
}