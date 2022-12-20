int firstNumber;
int secondNumber;

try
{
    Console.Write("Введите первое число: ");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    secondNumber = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Введено не целое число");
    return;
}

if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
}
else
{
    Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
}