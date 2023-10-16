using System;

namespace MyConsoleApp
{
    class Tests
    {
        public static void TestAllFunctions()
        {
            TestDetectWUBRG();
            TestCalculateFactorial();
            TestAreArraysEqual();
            TestRemoveDuplicates();
            TestCalculateExponentiation();
            ConvertToUpperCase();
            TestConvertToLowerCase();
            TestSumOfEvenNumbers();
            TestHasUniqueCharacters();
            TestIsPalindrome();
            TestIsPrime();
            TestSimpleSort();
            TestReverseString();
            TestSumArrayElements();
            TestFindMin();
            TestCountOccurrences();
            TestAreAnagrams();
            TestHasUniqueCharacters();
            TestSumOfEvenNumbers();
            TestConvertToLowerCase();
            ConvertToUpperCase();
            TestCalculateExponentiation();
            TestRemoveDuplicates();
        }

        static void TestDetectWUBRG()
        {
            bool passed = true;
            Console.Write("Testing DetectWUBRG\t\t");
            try
            {
                passed = passed && SimpleFunctions.DetectWUBRG("wurgaanb") == true;
                passed = passed && SimpleFunctions.DetectWUBRG("") == false;
                passed = passed && SimpleFunctions.DetectWUBRG("aaaaabbbbuuurrr") == false;
                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestCalculateFactorial()
        {
            bool passed = true;
            Console.Write("Testing CalculateFactorial\t");
            try
            {
                passed = passed && SimpleFunctions.CalculateFactorial(1) == 1;
                passed = passed && SimpleFunctions.CalculateFactorial(6) == 720;
                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestIsPalindrome()
        {
            bool passed = true;
            Console.Write("Testing IsPalindrome\t\t");
            try
            {
                passed = passed && SimpleFunctions.IsPalindrome("a") == true;
                passed = passed && SimpleFunctions.IsPalindrome("aabbaa") == true;
                passed = passed && SimpleFunctions.IsPalindrome("abcde") == false;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestIsPrime()
        {
            bool passed = true;
            Console.Write("Testing IsPrime\t\t\t");
            try
            {
                passed = passed && SimpleFunctions.IsPrime(4) == false;
                passed = passed && SimpleFunctions.IsPrime(7) == true;
                passed = passed && SimpleFunctions.IsPrime(8) == false;
                passed = passed && SimpleFunctions.IsPrime(17) == true;
                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestSimpleSort()
        {
            bool passed = true;
            Console.Write("Testing SimpleSort\t\t");
            try
            {
                passed = passed && AreArraysEqual(SimpleFunctions.SimpleSort(new int[] { 1, 5, 7, 9, 2, 3, 4 }), new int[] { 1, 2, 3, 4, 5, 7, 9 });
                passed = passed && AreArraysEqual(SimpleFunctions.SimpleSort(new int[] { 1, 10, 5, 20, 15 }), new int[] { 1, 5, 10, 15, 20 });

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestReverseString()
        {
            bool passed = true;
            Console.Write("Testing ReverseString\t\t");
            try
            {
                passed = passed && SimpleFunctions.ReverseString("123456") == "654321";
                passed = passed && SimpleFunctions.ReverseString("abcdefgh") == "hgfedcba";

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestSumArrayElements()
        {
            bool passed = true;
            Console.Write("Testing SumArrayElements\t");
            try
            {
                passed = passed && SimpleFunctions.SumArrayElements(new int[] { 1, 1, 1, 1, 1 }) == 5;
                passed = passed && SimpleFunctions.SumArrayElements(new int[] { 1, 2, 3, 4, 1 }) == 11;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }
        static void TestFindMin()
        {
            bool passed = true;
            Console.Write("Testing FindMin\t\t\t");
            try
            {
                passed = passed && SimpleFunctions.FindMin(new int[] { 3, 6, 9, 1, 4, 7 }) == 1;
                passed = passed && SimpleFunctions.FindMin(new int[] { 3, 6, 0, 4, 7 }) == 0;


                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestCountOccurrences()
        {
            bool passed = true;
            Console.Write("Testing CountOccurrences\t");
            try
            {
                passed = passed && SimpleFunctions.CountOccurrences("Charizard", 'a') == 2;
                passed = passed && SimpleFunctions.CountOccurrences("Alan", 'a') == 1;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestAreAnagrams()
        {
            bool passed = true;
            Console.Write("Testing AreAnagrams\t\t");
            try
            {
                passed = passed && SimpleFunctions.AreAnagrams("sleep", "peesl") == true;
                passed = passed && SimpleFunctions.AreAnagrams("sleep", "pesl") == false;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestHasUniqueCharacters()
        {
            bool passed = true;
            Console.Write("Testing HasUniqueCharacters\t");
            try
            {
                passed = passed && SimpleFunctions.HasUniqueCharacters("123456789") == true;
                passed = passed && SimpleFunctions.HasUniqueCharacters("") == true;
                passed = passed && SimpleFunctions.HasUniqueCharacters("aaabbbbccc") == false;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestSumOfEvenNumbers()
        {
            bool passed = true;
            Console.Write("Testing SumOfEvenNumbers\t");
            try
            {
                passed = passed && SimpleFunctions.SumOfEvenNumbers(new int[] { 2, 3, 4, 5, 6 }) == 12;
                passed = passed && SimpleFunctions.SumOfEvenNumbers(new int[] { 1, 3, 5, 7 }) == 0;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestConvertToLowerCase()
        {
            bool passed = true;
            Console.Write("Testing ConvertToLowerCase\t");
            try
            {
                passed = passed && SimpleFunctions.ConvertToLowerCase("ChARIZARD") == "charizard";
                passed = passed && SimpleFunctions.ConvertToLowerCase("CHUFFED ALAN") == "chuffed alan";

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }
        static void ConvertToUpperCase()
        {
            bool passed = true;
            Console.Write("Testing ConvertToUpperCase\t");
            try
            {
                passed = passed && SimpleFunctions.ConvertToUpperCase("charizard") == "CHARIZARD";
                passed = passed && SimpleFunctions.ConvertToUpperCase("ALAN") == "ALAN";

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }
        static void TestCalculateExponentiation()
        {
            bool passed = true;
            Console.Write("Testing CalculateExponentiation\t");
            try
            {
                passed = passed && SimpleFunctions.CalculateExponentiation(200, 0) == 1;
                passed = passed && SimpleFunctions.CalculateExponentiation(4, 2) == 16;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestRemoveDuplicates()
        {
            bool passed = true;
            Console.Write("Testing RemoveDuplicates\t");
            try
            {
                passed = passed && AreArraysEqual(SimpleFunctions.RemoveDuplicates(new int[] { 1, 2, 2, 3, 4, 4 }), new int[] { 1, 2, 3, 4 });
                passed = passed && AreArraysEqual(SimpleFunctions.RemoveDuplicates(new int[] { 1, 2, 2, 3, 4, 4, 5, 6, 88 }), new int[] { 1, 2, 3, 4, 5, 6, 88 });

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        static void TestAreArraysEqual()
        {
            bool passed = true;
            Console.Write("Testing AreArraysEqual\t\t");
            try
            {
                passed = passed && SimpleFunctions.AreArraysEqual(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }) == true;
                passed = passed && SimpleFunctions.AreArraysEqual(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 }) == false;

                Console.WriteLine(passed ? "Passed" : "Failed");
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Not Implemented");
            }
        }

        // This Comment is here to be a template for future tests
        // static void Test()
        // {
        //     bool passed = true;
        //     Console.Write("Testing \t");
        //     try
        //     {
        //         passed = passed && SimpleFunctions

        //         Console.WriteLine(passed ? "Passed" : "Failed");
        //     }
        //     catch (NotImplementedException e)
        //     {
        //         Console.WriteLine("Not Implemented");
        //     }
        // }

        static bool AreArraysEqual<T>(T[] array1, T[] array2)
        {
            // Check if the arrays have the same length
            if (array1.Length != array2.Length)
            {
                return false;
            }

            // Compare each element in the arrays
            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i]))
                {
                    return false;
                }
            }

            // If all elements are equal, return true
            return true;
        }
    }


}
