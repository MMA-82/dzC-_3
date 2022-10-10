Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int result = 1;
if(N>0)
{
while(i <= N)
{
    result = result * i;
    i++;        
}
Console.WriteLine("Произведение всех чисел равно: " + result);
}
else Console.WriteLine("Вы ввели отрицательное число!!!"); 