Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int lastN = number % 10;
Console.WriteLine("Последняя цифра трёхзначного числа - " + lastN);