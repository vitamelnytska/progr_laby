using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Array a = new Array(0,5); // 0 <> 9
            
            int l = a.Length_array;
            a[0] = 3;
            a[1] = 5;
            a[2] = 4;
            a[3] = 21;
            a[4] = 54;
            Console.WriteLine("\tMelnytska Vitaliya IS-92 ");
            int b = a[6];
            int j = a[3];
            Console.WriteLine(b);
            if (b == 0) Console.WriteLine("Error.\nindex is out of the bounds of the array.");
            Console.WriteLine(" element №4: "+ j);
            Console.WriteLine("length of array: " + l);
        }
    }
}
