Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while(i <= N)
{
    //int Cube = i*i*i;
    if(Math.Pow(i, 3)%10%2 == 0) Console.WriteLine(Math.Pow(i, 3));
    i++;
}    
