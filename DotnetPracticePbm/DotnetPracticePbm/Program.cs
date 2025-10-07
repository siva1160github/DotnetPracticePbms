using DotnetPracticePbm;

static void Functionality()
{
    Console.WriteLine("1.ReverseString");
    Console.WriteLine("2.String Palindrome");
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
    }
    Functionality();
}

Functionality();

