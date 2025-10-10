using DotnetPracticePbm;

static void Functionality()
{
    Console.WriteLine("1.ReverseString");
    Console.WriteLine("2.String Palindrome");
    Console.WriteLine("3.Integer Palindrome");
    Console.WriteLine("4.Second Largest Number");
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
    }
    Functionality();
}

Functionality();

