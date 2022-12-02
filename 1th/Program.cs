Console.WriteLine("Введите 1-число");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-число");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("Числа являются одинаковыми. Повторите ввод!");
}

else 

if ( firstNumber > secondNumber )
{
    Console.Write("Наибольшее число ");
    Console.WriteLine(firstNumber);
}
else
{
    Console.Write("Наибольшее число ");
    Console.WriteLine(secondNumber);
}







