using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
           int c = a + b;
            return c;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            int remainder = number % 2;
            if (remainder > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            int Thebigboy;
            int Potential_bigboy = Math.Max(a, b);
            if (c > Potential_bigboy)
            {
                Thebigboy = c;
            }
            else
            {
                Thebigboy = Potential_bigboy;
            }
            return Thebigboy;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int stringlength = s.Length;
            return stringlength;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            //Ethan here: I couldn't figure out "StartsWith", so I improvised.
            //May return later?
            bool doesStartHello = true; 
            string hello = "Hello";
            char[] gigaHello = hello.ToCharArray();
            char [] searchedWord = s.ToCharArray();
            for (int i = 0; i < hello.Length; i++)
            {
                if (gigaHello[i] != searchedWord[i])
                {
                    doesStartHello = false;
                    break;
                }
            }
            return doesStartHello;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            char[] ReversedcharArray = new char[charArray.Length];
            for(int i = 0; i < charArray.Length; i++)
            {
                ReversedcharArray[i] = charArray[charArray.Length-i];
            }

            return new string(ReversedcharArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) 
            {
                return 1;
            }
            int totalFactorial = 1;
            for (int i = n-1; i>= 1; i--)
            {
                totalFactorial = totalFactorial*i;
            }
            return totalFactorial;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) 
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                {
                    return false;
                }
            }
            
            return true;
        }

        // 9. Return the n-th Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) 
            {
                return n;
            }
            int[] fibonacci = new int[n];
            fibonacci [0] = 0;
            fibonacci [1] = 1;
            for(int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i-1] * fibonacci[i-2];
            }
            
            return fibonacci[n];
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            bool isItPalindrome = true;
            char[] normalRead = s.ToCharArray();
            string reversedWord = ReverseString(s);
            char[] reversedRead = reversedWord.ToCharArray();
            for (int i = 0; i<s.Length; i++)
            {
                if(normalRead[i] != reversedRead[i])
                {
                    isItPalindrome = false;
                }
            }
            return isItPalindrome;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            return "";
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            return "";
        }
    }
}
