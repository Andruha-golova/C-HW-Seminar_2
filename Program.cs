System.Console.WriteLine("enter three-digit number:");

int number = Convert.ToInt32(Console.ReadLine());

int AverageNumber = (number % 100) / 10;

System.Console.WriteLine($"average number {AverageNumber}");