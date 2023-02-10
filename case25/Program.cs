// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Clear();
Console.WriteLine("Enter the number A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number B: ");
int B = int.Parse(Console.ReadLine());

int Result(int num1, int num2)
{
    int Res = 1;
for (int i=1; i<=num2; i++)
    Res= Res*num1;
return Res;
}
Console.WriteLine($"The number {A} in {B} is {Result(A,B)}");
