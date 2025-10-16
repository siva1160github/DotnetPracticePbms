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
    }
    Functionality();
}

Functionality();

