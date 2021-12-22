int number = new Random().Next(10, 100);
Console.WriteLine(number);
int first = number % 10;
int second = (number / 10) % 10;
if(first > second)
{
    Console.WriteLine("Наибольшая цифра из числа - " + first);
}
else
{
    Console.WriteLine("Наибольшая цифра из числа - " + second);
}