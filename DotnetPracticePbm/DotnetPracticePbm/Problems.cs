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
    }
}
