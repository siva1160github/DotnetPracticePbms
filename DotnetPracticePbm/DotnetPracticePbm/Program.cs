using DotnetPracticePbm;

static void Functionality()
{
    Console.WriteLine("1.ReverseString");
    Console.WriteLine("2.String Palindrome");
    Console.WriteLine("3.Integer Palindrome");
    Console.WriteLine("4.Second Largest Number");
    Console.WriteLine("5.Missing Number In Array");
    Console.WriteLine("6.CommonElementsInArray");
    Console.WriteLine("7.Count Digits in an Integer");
    Console.WriteLine("8.Check String Contains Digits");
    Console.WriteLine("9.Reverse words in a sentence");
    Console.WriteLine("10.OwnContains");
    Console.WriteLine("11.First non-repeated character");
    Console.WriteLine("12.Factorial");
    Console.WriteLine("13.FactorialRecursion");
    Console.WriteLine("14.Fibonacci");
    Console.WriteLine("15.DuplicateCharsInString");
    Console.WriteLine("16.RemoveDuplicatesInArray");
    Console.WriteLine("17.FizzBuzz");
    Console.WriteLine("18.LongestWordInSentence");
    Console.WriteLine("19.RightRotateArrayKPos");
    Console.WriteLine("20.LeftRotateArrayKPos");
    int input = int.Parse(Console.ReadLine());
    Problems problem = new();
    switch (input)
    {
        case 1:
            Console.WriteLine(problem.ReverseString());
            break;
        case 2:
            Console.WriteLine(problem.CheckPalindrome());
            break;
        case 3:
            Console.WriteLine(problem.CheckIntegerPalindrome());
            break;
        case 4:
            Console.WriteLine(problem.SecondLargestNumber());
            break;
        case 5:
            Console.WriteLine(problem.MissingNumberInArray());
            break;
        case 6:
            Console.WriteLine(problem.CommonElementsInArray());
            break;
        case 7:
            Console.WriteLine(problem.CountDigits());
            break;
        case 8:
            Console.WriteLine(problem.ContainsDigits());
            break;
        case 9:
            Console.WriteLine(problem.ReverseWordsInSentence());
            break;
        case 10:
            Console.WriteLine(problem.Contains());
            break;
        case 11:
            Console.WriteLine(problem.FirstNonRepCharacter());
            break;
        case 12:
            Console.WriteLine(problem.Factorial());
            break;
        case 13:
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(problem.FactorialRecursion(n));
            break;
        case 14:
            Console.WriteLine(problem.Fibonacci());
            break;
        case 15:
            problem.DuplicateCharsInString();
            break;
        case 16:
            problem.RemoveDuplicatesInArray();
            break;
        case 17:
            problem.FizzBuzz();
            break;
        case 18:
            problem.LongestWordInSentence();
            break;
        case 19:
            problem.RightRotateArrayKPos();
            break;
        case 20:
            problem.LeftRotateArrayKPos();
            break;
    }
    Functionality();
}

Functionality();

