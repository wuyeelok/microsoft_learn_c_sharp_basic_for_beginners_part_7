// See https://aka.ms/new-console-template for more information
var part = "Part 7";
Console.WriteLine($"Hello, World! {part}");

// Version 1
int a = int.MaxValue;
int b = 1;
long c = (long)a + b;
Console.WriteLine(c);


// Version 2
int d = int.MaxValue;
int e = 1;
long f = checked(d + e);
Console.WriteLine(f);