int n = int.Parse(Console.ReadLine());
int num = 0;
int sum = 1;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(sum);
    num += sum;
    sum += 2;
}
Console.WriteLine($"Sum: {num}");