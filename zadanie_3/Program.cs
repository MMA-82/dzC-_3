Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result = 1;

while(i <= N)
{
    result = result * i;
    i++;        
}
Console.WriteLine("Произведение всех чисел равно: " + result);
