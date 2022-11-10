//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите размерность массива:");
int arrLength = int.Parse(Console.ReadLine() ?? "0");

double[] array = GetArray(arrLength);

Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {MaxArray(array)}");
Console.WriteLine($"Минимальный элемент массива: {MinArray(array)}");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива: {MaxArray(array) - MinArray(array)}");

double[] GetArray(int size) // Метод заполняет массив вещественными числами от -100 до 100
{
    Console.WriteLine("Ваш массив:");
    double[] res = new double[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().NextDouble() +  new Random().Next(-100, 100+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

double MaxArray(double[] arr) // Метод ищет максимальный элемент
{
    double max = arr[0];
    foreach(double el in arr)
    {
        if (el > max) max = el;
    }
    return max;
}

double MinArray(double[] arr) // Метод ищет минимальный элемент
{
    double min = arr[0];
    foreach(double el in arr)
    {
        if (el < min) min = el;
    }
    return min;
}