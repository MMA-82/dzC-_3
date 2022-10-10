Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if(N%10%2 == 0)
{
    Console.WriteLine("Куб введенного числа равен: " + Math.Pow(N, 3));
}
else Console.WriteLine("У введенного числа последняя цифра нечетная!");
