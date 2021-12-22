Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ??"0" );
int i = 0;
while( i <= N*2 )
{
    int number = -N + i;
    Console.Write(number + " ");
    i ++;
}