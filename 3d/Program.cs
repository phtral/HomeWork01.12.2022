Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

if( x % 2 == 1)
{
    Console.WriteLine("Число является нечетным");
    Console.WriteLine(x % 2);
}
else
{
   Console.WriteLine("Число является четным");
   Console.WriteLine(x % 2);
}
