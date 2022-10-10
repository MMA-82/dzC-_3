Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
if(x>9)
{
    while(x > 0)
    {
        sum = sum + x%10;
        x = x/10;
    }
    Console.WriteLine("Сумма цифр числа равна: " + sum);
}
else 
{
    if(x>=0) 
    {
    Console.WriteLine("Сумма цифр числа равна: " + x);
    }
    else Console.WriteLine("Введено отрицательное число!!!");
}
    
