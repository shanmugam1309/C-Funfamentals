// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Shanmugam!");
Console.WriteLine("Good Day!");

Console.Write("Successfully!!");
Console.Write("Login!\n");

String function = "Hello";
Console.WriteLine($"Hi {function}");

String function1 = "Hello";
String function2 = "Hello";
Console.WriteLine($"Hi {function1} and {function2}");

function1 = function1.Replace("Hello", "Greeting");
Console.WriteLine(function1);

Console.WriteLine(function1.ToUpper());
Console.WriteLine(function1.ToLower());

String Song = "You say goodbye, and I say hello";
Console.WriteLine(Song.Contains("goodbye"));
Console.WriteLine(Song.Contains("Greetings"));

String Songs = "You say goodbye, and I say hello";

var result = Songs.StartsWith("You");
Console.WriteLine("result");
Console.WriteLine(Song.Contains("Greetings"));


int a = 30;
int b = 3;
int c = a + b;
Console.WriteLine(c);

int x = 30;
int y = 3;
int z = 20;
int m = (x + y) * z;
Console.WriteLine(m);

int h = 30;
int o = 3;
int j = 20;
int k = (h + o) * j;
int e = (h + o) / j;
Console.WriteLine($"quotient: {k}");
Console.WriteLine($"remainder: {e}");

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of integers is (min) to (max)");


int g = 1000000;
int l = 2000000;
long n = (long)g + (long)l;
Console.WriteLine(n);

//int q = 20;
//int w = 33;
//if ((q + w) > 50)
//    Console.WriteLine("The value is greater than 50.");

int q = 20;
int w = 23;
int t = q + w;
bool demo = t > 50;
if (demo)
{
    Console.WriteLine("The value is greater than 50.");
}
else
{
    Console.WriteLine("The value is less than 50.");
}

//int counter = 0;
//while (counter < 5)
//{
//    counter++;
//    Console.WriteLine(counter);
//}

for (int i = 0; i < 5; i++)
{
    if (i == 3);
    {
        Console.WriteLine(i);
    }

}

//var names = new List<string> { "Naveen", "Jana", "mugesh"};
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");x
//}

var numbers = new List<int> { 45, 56, 99, 48, 67, 78 };
numbers.Sort();
Console.WriteLine($"I found 99 at index{numbers.IndexOf(99)}");
foreach (var number in numbers)
{
    Console.WriteLine($"{number}!");
}

//OOPS CONCEPT

// class and object
class car
{
    string color1 = "red";
    static void main(string[] args)
    {
        car carobj = new car();
        Console.WriteLine(carobj.color1);
    }
}

