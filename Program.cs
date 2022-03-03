using System;

namespace Act1
{
    class Program
    {
        static int setArrayNumber()
        {
            int varArr;
            Console.WriteLine("##### Enter the Length for the Array: ######");
            varArr = Convert.ToInt32(Console.ReadLine());
            return varArr;
        }

        static void revArr(int[] arr)
        {
            Array.Reverse(arr);

            Console.WriteLine("##### In Reverse Way ######");
            foreach(int el in arr)
            {
                Console.WriteLine(el);
            }
        }

        static void displayArray(int[] arr)
        {
            Console.WriteLine("##### The Values on Array are: ######");
             for(int i = 0; i < arr.Length; i++)
             {
                Console.WriteLine("On: " + i + " = " + arr[i]);
             }

            revArr(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("##### Add elements on Array ######");

            int len = setArrayNumber();
            int[] arr = new int[len];
            int inp;

            for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("##### Add element " + i + " #####");
                    inp = Convert.ToInt32(Console.ReadLine());
                    arr[i] = inp;
                }

            displayArray(arr);
        }
    }
}
