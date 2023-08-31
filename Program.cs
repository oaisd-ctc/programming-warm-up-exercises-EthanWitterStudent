using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Linq;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_a = 5;
            int number_b = 14;
            int number_c = 9;
            int[] numberArray = {number_a, number_b, number_c};

            string dog = "dog";
            string deadMeme = "Big Chungus";
            
            Console.WriteLine(Add(number_a, number_b));
            
            Console.WriteLine(IsEven(number_c));
            
            Console.WriteLine(MaxOfThree(number_a, number_b, number_c));
            
            Console.WriteLine(StringLength(deadMeme));
            
            Console.WriteLine(StartsHello("helLo"));
            Console.WriteLine(StartsHello(dog));

            Console.WriteLine(ReverseString(deadMeme));  
            
            Console.WriteLine(Factorial(number_c));  
            
            Console.WriteLine(IsPrime(number_a));
            
            Console.WriteLine(Fibonacci(number_b));
            Console.WriteLine(Fibonacci(1));

            Console.WriteLine(LargestInArray(numberArray));
            
            Console.WriteLine(IsPalindrome(dog));
            Console.WriteLine(IsPalindrome("madaM"));

            Console.WriteLine(ArraySum(numberArray));
            
            Console.WriteLine(CharCount(deadMeme, 'U'));

            Console.WriteLine(ConcatenateStrings(dog, deadMeme));
            
            Console.WriteLine(SwapEnds(dog));
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
            
            //Had to return later. Its not caps insensitive!

            if(s.StartsWith("hello", StringComparison.InvariantCultureIgnoreCase) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            char[] ReversedcharArray = new char[charArray.Length];
            for(int i = 0; i < charArray.Length; i++)
            {
                
                ReversedcharArray[i] = charArray[charArray.Length-i-1];
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
            int totalFactorial = n;
            for (int i = n-1; i > 0; i--)
            {
                totalFactorial = totalFactorial * i;
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

            int[] fibonacci = new int[n+1];
            
            fibonacci [0] = 0;
            fibonacci [1] = 1;
            for(int i = 2; i <= n; i++)
            {
                fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
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
            string reversedWord = ReverseString(s);

            int placeholdNum = String.Compare(s, reversedWord, true);
            if (placeholdNum != 0)
            {
                isItPalindrome = false;
            }

            return isItPalindrome;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum = sum+num;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {   //Ethan note: capitalizing everything doesn't always work for caps insensitive, because languages like Turkey exist
            //However, this assignment is in English, so this little oversight hopefully won't matter

            s = s.ToUpper();
            c = Char.ToUpper(c);
            int count = s.Count(x => x == c);
            
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            return new string (str1 + " " + str2);
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) 
            {
                return s;
            }
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            char[] s2 = s.ToCharArray();
            s2[0] = lastChar;
            s2[s2.Length-1] = firstChar;
            
            return new string(s2);
        }
    }
}
