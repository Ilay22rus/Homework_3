Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count <= N)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}