System.Console.WriteLine("enter number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("the third digit is missing");
}
else
{
    while (number > 999)
    {
        number /= 10;
    }
    System.Console.WriteLine(number%10);
}