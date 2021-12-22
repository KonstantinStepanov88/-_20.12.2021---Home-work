Console.WriteLine("Введите два числа: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
int numberB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Является ли первое число квадратом второго? - ");
if(numberA == numberB * numberB)
{
    Console.Write("True");
}
else
{
    Console.Write("False");
}