string typeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int sum = 0;
if (age >= 0 && age <= 18)
{
    switch (typeOfDay)
    {
        case "Weekday":
            sum += 12;
            break;
        case "Weekend":
            sum += 15;
            break;
        case "Holiday":
            sum += 5;
            break;
    }
    Console.WriteLine($"{sum}$");
}
else if (age > 18 && age <= 64)
{
    switch (typeOfDay)
    {
        case "Weekday":
            sum += 18;
            break;
        case "Weekend":
            sum += 20;
            break;
        case "Holiday":
            sum += 12;
            break;
    }
    Console.WriteLine($"{sum}$");
}
else if (age > 64 && age <= 122)
{
    switch (typeOfDay)
    {
        case "Weekday":
            sum += 12;
            break;
        case "Weekend":
            sum += 15;
            break;
        case "Holiday":
            sum += 10;
            break;
    }
    Console.WriteLine($"{sum}$");
}
else
{
    Console.WriteLine("Error!");
}