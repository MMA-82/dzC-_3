Console.Write("Введите предельное число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while(i <= N)
{
    Console.WriteLine(" " + (i * i * i));
    i++;
}
