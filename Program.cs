using System.Text;

// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello again");
string[] strs = {"one", "two", "three"};
string make = "Mercedes-Benz";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

int theVal = 40;

Console.WriteLine(theVal < 50 ? "theVal is smaller than 50" : "theVal is larger than 50"); //"theVal is large"

Console.WriteLine("{0:D}", theVal);

Console.WriteLine("{0, 12} {1, 12}", "Name", "Email");
Console.WriteLine("{0, 12} {1, 12}", "Brian", "brianfgonzalez@gmail.com");

// string interpolation
Console.WriteLine($"This car is a {year} {make} {model}, with {miles:N0} miles and costs {price:C0}.");


Console.WriteLine($"This car is a {year} {make} {model}, with {(miles*1.6):N0} kilometers and costs {price:C0}.");
*/
//stringBuilder - strings are immutable
int jumpCount = 100;
string[] animals = {"pigs", "cats", "dogs", "birds"};
StringBuilder sb = new StringBuilder("Initial string.", 200);

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
sb.Append(" and here is appended data.");
sb.AppendLine();
sb.AppendFormat("Hi jumped {0} times over: ", jumpCount);
sb.AppendJoin(",", animals);
sb.Replace("dogs", "crows");

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
Console.WriteLine(sb.ToString());


// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings