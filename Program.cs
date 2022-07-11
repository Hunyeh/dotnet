// See https://aka.ms/new-console-template for more information

// using System;
// namespace CatWorx.BadgeMaker
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.WriteLine("Hello, World!");
//     }
//   }
// }

// double side = 3.14;
// double area = side * side;
// Console.WriteLine("area: {0}", area);

// Data Types //

// int num = 10;
// num += 100;
// Console.WriteLine(num);
// num++;
// Console.WriteLine(num);

// Data Type Conversions

// string stringNum = "2";
// int intNum = Convert.ToInt16(stringNum);
// Console.WriteLine(intNum);
// Console.WriteLine(intNum.GetType());

// Data Structures //

// Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
// myScoreBoard.Add("firstInning", 10);
// myScoreBoard.Add("secondInning", 20);
// myScoreBoard.Add("thirdInning", 30);
// myScoreBoard.Add("fourthInning", 40);
// myScoreBoard.Add("fifthInning", 50);

// Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
//     { "firstInning", 10 },
//     { "secondInning", 20},
//     { "thirdInning", 30},
//     { "fourthInning", 40},
//     { "fifthInning", 50}
// };

// Console.WriteLine("----------------");
// Console.WriteLine("  Scoreboard");
// Console.WriteLine("----------------");
// Console.WriteLine("Inning |  Score");
// Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
// Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
// Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
// Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
// Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

// Arrays //

// string[] favFoods = new String[3]{"pizza", "tacos", "icecream"};
// string firstFood = favFoods[0];
// string secondFood = favFoods[1];
// string thirdFood = favFoods[2];
// Console.WriteLine("I like {0}, {1} and {2}", firstFood, secondFood, thirdFood);

// Lists //

// List<string> employees = new List<string>() {"adam","amy"};
// employees.Add("lynn");
// employees.Add("bob");
// Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

// Loops //

// List<string> employees = new List<string>() {"adam","amy"};
// employees.Add("lynn");
// employees.Add("bob");

// for (int i = 0; i < employees.Count; i++);
//     Console.WriteLine(employees[i]);                 // NOTWORKING


// List<string> employees = new List<string>() { "adam", "amy" };
// employees.Add("barbara");
// employees.Add("billy");
// Console.WriteLine("please enter your name: ");
// // get name from console and assign it to a variable
// string ? input = Console.ReadLine();
// employees.Add(input);
// for (int i = 0; i <employees.Count; i++)
// {
//     Console.WriteLine(employees[i]);
// }

// List<string> employees = new List<string>();
// // collect user values until the value is an empty string
// while (true)
// {
//     Console.WriteLine("please enter your name: (leave empty to exit)");
//     // get name from console and assign it to a variable
//     string? input = Console.ReadLine();
//     if (input == "")
//     {
//         break;
//     }
//     employees.Add(input);
//     for (int i = 0; i < employees.Count; i++)
//     {
//         Console.WriteLine(employees[i]);
//     }
// }

// // assigns List<string> to employees
// List<string> employees = GetEmployees();
// for (int i = 0; i < employees.Count; i++)
// {
//     Console.WriteLine(employees[i]);
// }

// returns a List<string> 
static List<string> GetEmployees()
{
    List<string> employees = new List<string>();
    while(true) 
    {
        Console.WriteLine("please enter a name (leave empty to exit)");
        string input = Console.ReadLine();
        if (input == "")
        {
            break;
        }
        employees.Add(input);
    }
    return employees;
}

static void PrintEmployees(List<string> employees)
{
    for (int i = 0; i < employees.Count; i++)
    {
        Console.WriteLine(employees[i]);
    }
}
List<string> employees = GetEmployees();
PrintEmployees(employees);


