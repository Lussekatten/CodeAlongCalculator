// See https://aka.ms/new-console-template for more information

using CodeAlongCalculator;

Test test = new Test();
test.Total = 100;
int a = 1;
int b = 2;

int c = a + b;
int sum = ReturnSum(a, b);
Console.WriteLine(c);

Console.WriteLine($"Original value: {test.Total}");
PassByReference(test);
Console.WriteLine($"New value: {test.Total}");

Console.WriteLine("Summan av {0} plus {1} är lika med {2}", a, b, c);
Console.WriteLine($"Summan av {a} plus {b} är lika med {c}");
Console.WriteLine(sum);

if (a > b)
{
    int temp = 0;
    int r = 6;
    Console.WriteLine(temp);
}


static int ReturnSum(int param1, int param2)
{
    int temp = 10;
    param1++;
    param2++;
    return param1 + param2;
}

static void PassByReference(Test o)
{
    o.Total = 200;

}

bool runMe = true;

//int i = 5;
string userInput;

while (runMe)
{
    Console.WriteLine("Press a key (then Enter). End loop with A or a");
    userInput = Console.ReadLine();
    userInput = userInput.ToUpper();
    if (userInput == "A")
    {
        runMe = false;
    }
}
