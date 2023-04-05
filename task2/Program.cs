/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int Read()
{
    Console.Write("Entered number: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

int Sum(int number)
{

    int num_length = Length(number);
    int[] num = new int[num_length];
    int a = 0;
    int r = 0;

    for (int i = 0; i <= num_length - 1; i++)
    {
        a = number - number % 10;
        r = r + (number - a);
        number = number / 10;
    }
    return r;
}

static int Length(int number)
{
    int n = 0;

    while (number > 0)
    {
        number /= 10;
        n++;
    }
    return n;
}

int number = Read();
int sum = Sum(number);
Console.WriteLine($"summa liczb wynosi: {sum}");