int max = 0;

while (true)
{
    try
    {
        Console.WriteLine("Enter Interger between 1 and 100: ");
        max = Convert.ToInt32(Console.ReadLine());
        break;
    }catch(Exception)
    {
        Console.WriteLine("Only Integer numbers are allowed");
    }
}
Console.WriteLine("Specify series (Odd/Even): ");
String series = Console.ReadLine().ToLower();

Console.WriteLine("You have selected the ", series, "Series. The numbes between 0 and ", max, "are: ");

if (series == "odd")
{
    for (int i = 1; i<= max; i++)
    {
        if (i % 2 ==1)
        {
            Console.WriteLine(i);
        }
    }
}
if (series == "even")
{
    for (int i = 1; i <= max; i++)
    {
        if (i % 2 ==0)
        {
            Console.WriteLine(i);
        }
    }
}

