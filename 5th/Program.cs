Console.WriteLine("Input number");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Input number2");
int y = int.Parse(Console.ReadLine());

if(x == Math.Pow(y,2) || y == Math.Pow(y,2))
{
Console.WriteLine("Да, Является");
}

else{
    Console.WriteLine("Нет, Не является ");
}
