using System;

namespace MyConsoleApp
{
    public class SimpleFunctions
    {
        // Should return true if input contains the letters wubr and g in any order or capitalization
        public static bool DetectWUBRG(string input)
        {
            input = ConvertToLowerCase(input);
            return input.Contains('w') && input.Contains('u') && input.Contains('b') && input.Contains('r') && input.Contains('g');

        }

        // Calculate the factorial of a given number.
        public static int CalculateFactorial(int number)
        {
            return number == 1 ? 1 : number * CalculateFactorial(number - 1);
        }

        // Check if a given string is a palindrome.
        public static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right && right > 0)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        // Implement a simple sorting algorithm on an array of integers.
        public static int[] SimpleSort(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // Reverse a given string.
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Find the sum of all elements in an array.
        public static int SumArrayElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        // Find the maximum element in an array.
        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        // Count the occurrences of a specific element in an array or string.
        public static int CountOccurrences(string str, char target)
        {
            return str.Count(ch => ch == target);
        }

        // Check if two strings are anagrams of each other.
        public static bool AreAnagrams(string str1, string str2)
        {
            string sortedStr1 = new string(str1.OrderBy(c => c).ToArray());
            string sortedStr2 = new string(str2.OrderBy(c => c).ToArray());

            // Compare the sorted strings
            return sortedStr1.Equals(sortedStr2, StringComparison.OrdinalIgnoreCase);
        }

        // Check if a string contains only unique characters.
        public static bool HasUniqueCharacters(string str)
        {
            HashSet<char> charSet = new HashSet<char>();

            foreach (char c in str)
            {
                if (charSet.Contains(c))
                {
                    return false;
                }
                charSet.Add(c);
            }

            return true;
        }

        // Calculate the sum of all even numbers in a given array.
        public static int SumOfEvenNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }
            return sum;
        }

        // Convert a string to lowercase.
        public static string ConvertToLowerCase(string str)
        {
            return str.ToLower();
        }

        // Convert a string to uppercase.
        public static string ConvertToUpperCase(string str)
        {
            return str.ToUpper();
        }

        // Calculate the exponentiation of a base to a given power.
        public static double CalculateExponentiation(double @base, int exponent)
        {
            return Math.Pow(@base, exponent);
        }

        // Remove duplicates from an array.
        public static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        // Check if two arrays are equal.
        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            // Check if the arrays have the same length
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            // Compare each element in the arrays
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr1[i].Equals(arr2[i]))
                {
                    return false;
                }
            }

            // If all elements are equal, return true
            return true;
        }

        // Find the second largest element in an array.
        public static int FindSecondLargest(int[] arr)
        {
            throw new NotImplementedException();
        }

        // Calculate the greatest common divisor (GCD) of two numbers.
        public static int FindGCD(int a, int b)
        {
            throw new NotImplementedException();
        }

        // Remove a specific character from a string.
        public static string RemoveCharacter(string str, char c)
        {
            throw new NotImplementedException();
        }

        // Merge two sorted arrays into one sorted array.
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            throw new NotImplementedException();
        }

        // Calculate the square of a number.
        public static int CalculateSquare(int number)
        {
            throw new NotImplementedException();
        }

        // Check if a number is even or odd.
        public static bool IsEven(int number)
        {
            throw new NotImplementedException();
        }

        // Calculate the length of the hypotenuse of a right-angled triangle.
        public static double CalculateHypotenuseLength(double a, double b)
        {
            throw new NotImplementedException();
        }
    }


}