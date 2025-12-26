using System.Text;

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

        public void DuplicateCharsInString()
        {
            Console.WriteLine("Enter the String");
            string input = Console.ReadLine();
            HashSet<char> dummy = [];
            HashSet<char> duplicate = [];
            for (int i = 0; i < input.Length; i++)
            {
                if (!dummy.Add(input[i]))
                {
                    duplicate.Add(input[i]);
                }
            }

            Console.WriteLine($"The duplicate chars in {input} are");
            foreach (char c in duplicate)
            {
                Console.WriteLine(c);
            }
        }

        public void RemoveDuplicatesInArray()
        {
            Console.WriteLine("Enter the array size");
            int input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            for (int i = 0; i < input; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            HashSet<int> set = [.. array];
            array = [.. set];
            Console.WriteLine("The Array after removal of duplicates: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void FizzBuzz()
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public void LongestWordInSentence()
        {
            Console.WriteLine("Enter the Sentence");
            string sentence = Console.ReadLine();
            int longest = 0;
            string word = string.Empty;
            int count = 0;
            StringBuilder sb = new();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    if (count > longest)
                    {
                        longest = count;
                        word = sb.ToString();
                    }
                    count = 0;
                    sb = new();
                }
                else
                {
                    sb.Append(sentence[i]);
                    count++;
                }
            }

            if (count > longest)
            {
                word = sb.ToString();
            }

            Console.WriteLine($"The longest word in sentence is {word}");
        }

        public void RightRotateArrayKPos()
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the k positions");
            int k = int.Parse(Console.ReadLine());
            Array.Reverse(array);
            Array.Reverse(array, 0, k);
            Array.Reverse(array, k, array.Length - k);
            Console.WriteLine("Array elements after reversing");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void LeftRotateArrayKPos()
        {
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the k positions");
            int k = int.Parse(Console.ReadLine());
            Array.Reverse(array, 0, k);
            Array.Reverse(array, k, array.Length - k);
            Array.Reverse(array);
            Console.WriteLine("Array elements after reversing");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void DuplicateElementsInArray()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> dict = [];
            for (int i = 0; i < array.Length; i++)
            {
                if (!dict.TryAdd(array[i], 1))
                {
                    dict[array[i]]++;
                }
            }

            Console.WriteLine("The duplicate elements are ");
            foreach (var pair in dict.Where(x => x.Value > 1))
            {
                Console.WriteLine(pair.Key);
            }
        }

        public void StackList()
        {
            List<int> list = [];
            list.Add(5); //push
            list.Add(6);
            list.Add(7);

            if (list.Count > 0)
                list.RemoveAt(list.Count - 1); //pop

            int? top = list.Count > 0 ? list[^1] : null; //peek

            bool isEmpty = list.Count == 0; //empty check
        }

        public void ReverseLinkedList()
        {
            LinkedList<int> list = new();
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddFirst(4);

            LinkedList<int> reverseList = new();
            foreach (var node in list)
            {
                reverseList.AddFirst(node);
            }
        }

        public void FindMiddleNode()
        {
            LinkedList<string> list = new();
            list.AddLast("AB");
            list.AddLast("BC");
            list.AddLast("CD");
            list.AddLast("DE");
            list.AddLast("EF");

            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            Console.WriteLine($"The middle node is {slow.Value}");
        }
    }
}
