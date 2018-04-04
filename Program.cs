using System;

namespace basic13
{
    class Program
    {
        
        public static void Print1to255()
        {
            for(int idx =1; idx <=255; idx++)
            {
                Console.Write(idx + " ");
            }
        }

        public static void PrintOddNum()
        {
            for(var idx =1; idx <=255; idx++)
            {
                if(idx % 2 != 0) 
                {
                    Console.Write(idx + " ");
                 }
            }
        }
        
        public static void PrintSum()
        {
            int sum = 0;
            for(int idx =0; idx < 256; idx++){
                 sum += idx;
                 Console.WriteLine("New number: {0} Sum {1}", idx, sum);
            }

        }

        public static void IterateArray(int[] arr)
        {
            for(int idx=0; idx < arr.Length; idx++) 
            {
               Console.WriteLine(arr[idx]); 
            }

        }

        public static void FindMax(int[] arr)
        {
            int max =0;

            for(int idx=0; idx < arr.Length; idx++) {

                if(Math.Abs(arr[idx]) > Math.Abs(max)) {
                    max = arr[idx];
                 }
             }
             Console.WriteLine(max);
        }

        public static void GetAverage(int[] arr)
        {
            int sum = 0;

            for(int idx=0; idx < arr.Length; idx++) {
                sum += arr[idx];
            }

            double ave = (double)sum / arr.Length;
            Console.WriteLine("Average: {0}", ave);

        }

        public static void ArrayOddNumbers(int[] arr)
        {
            for(int idx = 0; idx < 256; idx++){
                if(idx % 2 != 0) {
                    arr[idx] = idx;
                    Console.Write(arr[idx] + " ");
                }
            }
        }

        public static void GreaterThanY(int[] arr, int Y)
        {
            int count = 0;
            for(int idx = 0; idx < arr.Length; idx++)
            {
                if( arr[idx] > Y){
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }

        public static void SquareTheValues(int [] myArr)
        {
            for(int idx = 0; idx < myArr.Length; idx++) {
                myArr[idx] = myArr[idx] * myArr[idx];
                Console.WriteLine(myArr[idx]);
            }
        }

        public static void EliminateNegativeNumbers(int [] arr)
        {
            for(int idx=0; idx < arr.Length; idx++) {
                if(arr[idx] < 0){
                    arr[idx] = 0;
                }
                Console.WriteLine(arr[idx]);
            }
        } 
        
        public static object[] ReplaceNumWithString(object[] arr) 
        {
            for(int idx = 0; idx < arr.Length; idx++) {
                if((int)arr[idx] < 0) {
                    arr[idx] = "Dojo";
                }
                Console.WriteLine(arr[idx]);
            }
            return arr;
        }

        public static void MinMaxAvg(int [] arr)
        {
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            double ave = 0;

            foreach(int val in arr) {
                sum += val;
                if(val < min){
                    min = val;
                }
                if(val > max){
                    max = val;
                }
            }
            Console.WriteLine("Max: {0}, Min: {1}, Ave: {2}", max, min, ave = (double)sum / arr.Length);
        }

        public static void ShiftArrayLeft(int [] arr)
        {
            for(int idx = 0; idx < arr.Length; idx++) {
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length - 1] = 0;      
        }

        public static object[] NegToFalse(object [] arr)
        {
            for( int idx = 0; idx < arr.Length; idx++) {
                if((int)arr[idx] < 0){
                    arr[idx] = false;
                }
                Console.WriteLine(arr[idx]);
            }
            return arr;
        }

        public static void Main(string[] args)
        {
           NegToFalse(new object [] {1,3,-8,-10});
            Print1to255();
            PrintOddNum();
            PrintSum();
            int [] myArr = new int[6] {1,3,5,7,19,20};
            IterateArray(myArr);
            FindMax(myArr);
            GetAverage(myArr);
            SquareTheValues(myArr);
            EliminateNegativeNumbers(myArr);
            GreaterThanY(myArr,3);
            MinMaxAvg(myArr);
            ShiftArrayLeft(myArr);
            object [] newArray = new object[] {-1,3,2,-16};
            ReplaceNumWithString(newArray);
            int [] newArr = new int[256];
            ArrayOddNumbers(newArr);
        }
    }
}
