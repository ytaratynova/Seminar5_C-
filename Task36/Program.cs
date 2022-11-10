//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размерность массива:");
int arrLength = int.Parse(Console.ReadLine() ?? "0");

int[] array = GetArray(arrLength);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {SummOddArray(array)}");

int[] GetArray(int size) // Метод заполняет массив
{
    Console.WriteLine("Ваш массив:");
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(-100, 100 + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int SummOddArray(int[] arr)
{
    int i = 1;
    int sum = 0;
    while (i < arr.Length)
    {
       sum = sum + arr[i];
       i = i + 2;
    }
    return sum;
}