Console.Write("Случайное число будет - ");
int number = new Random().Next(0, 100000000);
Console.WriteLine(number);
if(number >= 100)
{
    while(number >= 1000)
    {
        number = number / 10;
    }
    int third = number % 10;
    Console.WriteLine("Третья цифра в номере: " + third);
}
else
{
    Console.WriteLine("В числе нет третьей цифры");
}
