System.Console.WriteLine("enter number:");
int day = Convert.ToInt32(Console.ReadLine());
    if(day == 1)
{
    System.Console.WriteLine("monday");
} 
    else if(day == 2)
{
    System.Console.WriteLine("tuesday");
}
    else if(day == 3)
{
    System.Console.WriteLine("wensday");
}
    else if(day == 4)
{
    System.Console.WriteLine("thursday");
}         
    else if(day == 5)
{
    System.Console.WriteLine("friday");
}
    else if(day == 6)
{
    System.Console.WriteLine("saturday");
}
    else if(day == 7)
{
    System.Console.WriteLine("sunday");
}
    else 
{
    System.Console.WriteLine("no such day of the week");
}
    if((day > 5) == (day < 8))
{
    System.Console.WriteLine("weekend");
}
    if(day <= 5)
{
    System.Console.WriteLine("working day");
}