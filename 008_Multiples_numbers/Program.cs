int numberA = new Random().Next(1, 100000);
Console.WriteLine("случайное число, которое будем делить - " + numberA);
Console.WriteLine("Введите число на которое хотите делить:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("задаваемый делитель - " + numberB);
double result = numberA % numberB;

if( result == 0)
{
    Console.WriteLine("Числа кратны");
}
else
{
    Console.WriteLine("Остаток от деления равен " + result);
}