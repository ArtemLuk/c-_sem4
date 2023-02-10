// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Please enter the number "); 
int number = int.Parse(Console.ReadLine());

int[] Create(int N){
    int[] A = new int[N];
    for (int i=0; i<N; i++) {
        Console.WriteLine($"Please enter the {(i+1)} element of array");
        A[i] = int.Parse(Console.ReadLine());
        }
    return A;
}
int[] array = Create(number);
Console.Write($"[{String.Join(", ", array)}]");
