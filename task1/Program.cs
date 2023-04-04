/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Read(string number)
{
    Console.Write($"Enterde number {number}: ");
    int n = int.Parse(Console.ReadLine());
    return n;
}

void Math()
{
    int a = Read("A");
    int b = Read("B");
    int degree = 1;

    for (int i=1; i <= b; i++)
    {
        
            degree *= a;
        
    }
    Console.WriteLine($"{a} to the degree of {b} = {degree}");
}

Math();

