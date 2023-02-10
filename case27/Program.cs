// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Clear();
Console.WriteLine("Enter the number A: ");
int A = int.Parse(Console.ReadLine());

int SumDig(int N)
{
    int Sum = 0;
while (N!=0) {
    Sum = Sum + N%10;
    N=N/10;
    }
return Sum;
}
Console.WriteLine($"The Sum of digits of number {A} is {SumDig(A)}");
