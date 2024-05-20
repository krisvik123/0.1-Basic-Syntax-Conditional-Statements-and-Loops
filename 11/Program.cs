int n = int.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
if (num >= 10)
{
    Console.WriteLine($"{n} X {num} = {n * num}");
}
for (int i = num; i <= 10; i++)
{
    Console.WriteLine($"{n} X {i} = {n * i}");
}
