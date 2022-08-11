using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenerics
{
    internal static class TestCase
    {
        private static int[] intTestCase1;
        private static int[] intTestCase2;
        private static int[] intTestCase3;
        private static float[] floatTestCase1;
        private static float[] floatTestCase2;
        private static float[] floatTestCase3;
        private static string[] stringTestCase1;
        private static string[] stringTestCase2;
        private static string[] stringTestCase3;

  
        private static Maximum<int> maxInt;
        private static Maximum<float> maxFloat;
        private static Maximum<string> maxString;

       
        static TestCase()
        {
            intTestCase1 = new int[] { 5, 3, 9 };
            intTestCase2 = new int[] { 0, 4, 3 };
            intTestCase3 = new int[] { 7, 5, 4 };
            floatTestCase1 = new float[] { 1.3f, 2.5f, 5.7f };
            floatTestCase2 = new float[] { 2.3f, 7.5f, 5.7f };
            floatTestCase3 = new float[] { 9.3f, 8.5f, 5.7f };
            stringTestCase1 = new string[] { "Apple", "Banana", "Chocolate" };
            stringTestCase2 = new string[] { "Choco", "Chocolate", "Banana" };
            stringTestCase3 = new string[] { "Zoom", "Zap", "Zip" };
            maxInt = new(intTestCase1);
            maxFloat = new(floatTestCase1);
            maxString = new(stringTestCase1);
        }

      
        private static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }

        public static void IntTest()
        {
            Console.WriteLine("Test case 1: " + GetString(intTestCase1));
            maxInt.Max(intTestCase1[0], intTestCase1[1], intTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(intTestCase2));
            maxInt.Max(intTestCase2[0], intTestCase2[1], intTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(intTestCase3));
            maxInt.Max(intTestCase3[0], intTestCase3[1], intTestCase3[2]);
        }

        public static void FloatTest()
        {
            Console.WriteLine("Test case 1: " + GetString(floatTestCase1));
            maxFloat.Max(floatTestCase1[0], floatTestCase1[1], floatTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(floatTestCase2));
            maxFloat.Max(floatTestCase2[0], floatTestCase2[1], floatTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(floatTestCase3));
            maxFloat.Max(floatTestCase3[0], floatTestCase3[1], floatTestCase3[2]);
        }

        public static void StringTest()
        {
            Console.WriteLine("Test case 1: " + GetString(stringTestCase1));
            maxString.Max(stringTestCase1[0], stringTestCase1[1], stringTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(stringTestCase2));
            maxString.Max(stringTestCase2[0], stringTestCase2[1], stringTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(stringTestCase3));
            maxString.Max(stringTestCase3[0], stringTestCase3[1], stringTestCase3[2]);
        }
    }
}
