// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность массива:");
int arrLength = int.Parse(Console.ReadLine() ?? "0");

int[] array = GetArray(arrLength);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {EvenCount(array)}");

int[] GetArray(int size) // Метод заполняет массив, согласно условию
{
    Console.WriteLine("Ваш массив:");
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(100, 999 + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int EvenCount(int[] arr) // Метод считает четные числа в массиве
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}
