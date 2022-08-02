// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is the width of your rectangle?");
decimal width = decimal.Parse(Console.ReadLine());
Console.WriteLine("What is the height of your rectangle?");
decimal height = decimal.Parse(Console.ReadLine());
Console.WriteLine("The area of your rectangle is " + (width * height).ToString());