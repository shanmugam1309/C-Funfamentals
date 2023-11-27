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
Console.WriteLine($"I found 99 at index{numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"I found 99 at index{numbers.IndexOf(99)}");
foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}


//List<int> scores = new List<int> { 97, 92, 81, 60 };

//for (int i = 0; i < scores.Count; i++)
//{
//    if (scores[i] > 80)
//    {
//        Console.WriteLine($"Found a score > 80: {scores[i]}");
//    }
//}

List<int> scores = new List<int> { 97, 92, 81, 60 };
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $" The score is {score}";

Console.WriteLine(scoreQuery.Count());

foreach (string score in scoreQuery)
{
    Console.WriteLine(score);
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


// Types of Constructor 

// 1. Default constructor

public class MyClass
{
    // Default Constructor
    public MyClass()
    {
        // Initialization code (if needed)
    }
}

// 2. Parameterized constructor

public class Car
{
    public string Make;
    public string Model;

    // Parameterized Constructor
    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

// 3. Copy constructor

public class Person
{
    public string Name;
    public int Age;

    // Copy Constructor (using a method)
    public static Person CopyPerson(Person original)
    {
        return new Person { Name = original.Name, Age = original.Age };
    }
}

// 4. Static constructor

public class Myglas
{
    // Static Constructor
    static Myglas()
    {
        // Initialization code for static members
    }
}

// 5. Private constructor

public class Singleton
{
    private static Singleton instance;

    // Private Constructor
    private Singleton()
    {
        // Initialization code
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

// Session in dot net


public partial class SessionExample : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set a value in session state
            Session["UserName"] = "JohnDoe";
        }

        // Retrieve the value from session state
        string userName = Session["UserName"] as string;

        object lblUserName = null;
        // Display the value in a label on the web page
        lblUserName.Text = $"Welcome, {userName}!";
    }
}


// Boxing in dot net 



class Programm
{
    static void Main()
    {
        // Example of boxing
        int intValue = 42; // This is a value type (int)
        object boxedObject = intValue; // Boxing: int to object

        // Example of unboxing
        int unboxedValue = (int)boxedObject; // Unboxing: object to int

        // Display results
        Console.WriteLine($"Original Value (int): {intValue}");
        Console.WriteLine($"Boxed Value (object): {boxedObject}");
        Console.WriteLine($"Unboxed Value (int): {unboxedValue}");
    }
}



