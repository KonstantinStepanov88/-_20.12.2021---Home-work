Console.WriteLine("Случайное число будет - ");
int number = new Random().Next(-1000, 100000);
Console.WriteLine(number);
string numberA = number.ToString();
if(numberA.Length < 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    char chr = numberA[2];
    Console.WriteLine("третья цифра числа это: " + chr);
}