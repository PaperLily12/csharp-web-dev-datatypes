// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many miles have you driven?");
decimal miles = decimal.Parse(Console.ReadLine());
Console.WriteLine("How many gallons of gas have you used?");
decimal gallons = decimal.Parse(Console.ReadLine());
Console.WriteLine("Your gas mileage is " + miles/gallons + " miles per gallon.");