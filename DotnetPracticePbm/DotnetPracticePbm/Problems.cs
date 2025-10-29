﻿using System.Text;

namespace DotnetPracticePbm
{
    public class Problems
    {
        public string ReverseString()
        {
            Console.WriteLine("Please Enter the String");
            string input = Console.ReadLine();
            StringBuilder output = new();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }
            return output.ToString();
        }

        public bool CheckPalindrome()
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public bool CheckIntegerPalindrome()
        {
            Console.WriteLine("Enter the Number");
            int input = int.Parse(Console.ReadLine());
            int input1 = input;
            int reverseInput = 0;
            while (input1 > 0)
            {
                reverseInput = reverseInput * 10 + (input1 % 10);
                input1 = input1 / 10;
            }

            return reverseInput == input;
        }

        public int SecondLargestNumber()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array[0];
            int secondMax = max;
            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
                else if (array[i] > secondMax)
                {
                    secondMax = array[i];
                }
            }

            return secondMax;
        }

        public int MissingNumberInArray()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int actualSum = (size + 1) * (size + 2) / 2;

            return actualSum - array.Sum();
        }

        public int[] CommonElementsInArray()
        {
            int[] array1 = [1, 3, 4, 5, 6];
            int[] array2 = [2, 4, 6, 8, 10, 3];

            List<int> duplicates = [];

            Dictionary<int, int> dict = [];
            for (int i = 0; i < array1.Length; i++)
            {
                dict.Add(array1[i], 1);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (!dict.TryAdd(array2[i], 1))
                {
                    duplicates.Add(array2[i]);
                }
            }

            return [.. duplicates];
        }

        public int CountDigits()
        {
            Console.WriteLine("Enter the Integer");
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            while (input > 0)
            {
                input /= 10;
                count++;
            }
            return count;
        }

        public bool ContainsDigits()
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public string ReverseWordsInSentence()
        {
            Console.WriteLine("Enter the sentence");
            string input = Console.ReadLine();
            int end = input.Length - 1;
            StringBuilder output = new();
            for (int i = end; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    for (int j = i + 1; j <= end; j++)
                    {
                        output.Append(input[j]);
                    }
                    end = i - 1;
                    output.Append(' ');
                }
            }

            for (int i = 0; i <= end; i++)
            {
                output.Append(input[i]);
            }
            return output.ToString();
        }

        public bool Contains()
        {
            Console.WriteLine("Enter the sentence");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the search string");
            string search = Console.ReadLine();
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == search[j])
                {
                    j++;
                    if (j == search.Length)
                    {
                        return true;
                    }
                }
                else { j = 0; }
            }
            return false;
        }

        public char FirstNonRepCharacter()
        {
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            Dictionary<char, int> dict = [];
            for (int i = 0; i < word.Length; i++)
            {
                dict[word[i]] = dict.GetValueOrDefault(word[i], 0) + 1;
            }

            foreach (var pair in dict)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }

            return '\0';
        }

        public int Factorial()
        {
            Console.WriteLine("Enter the number");
            int input = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public int FactorialRecursion(int input)
        {
            if (input > 1)
            {
                return input * FactorialRecursion(input - 1);
            }
            return input;
        }

        public int Fibonacci()
        {
            int next = 1;
            int prev = 0;
            int output = 0;
            Console.WriteLine("Enter the number");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                output = prev + next;
                prev = next;
                next = output;
            }
            return output;
        }
    }
}
