int number = new Random().Next(100,1000);
Console.WriteLine("вот такой номер был на входе - " + number);
int first = (number / 100) % 10;
int third = number % 10;
Console.Write("а получился вот такой - ");
Console.WriteLine(first.ToString() + third.ToString());