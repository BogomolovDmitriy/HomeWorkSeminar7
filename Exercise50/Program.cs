/*
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] newArray = GetArray(3, 4);
PrintArray(newArray);

Console.Write("Введите номер  строки: ");
int rowNumber = int.Parse(Console.ReadLine());
Console.Write("Введите номер  столбца: ");
int columnNumber = int.Parse(Console.ReadLine());

GetItemArray(newArray);

void GetItemArray(int[,] array)
{
    if (rowNumber > array.GetLength(0) || columnNumber > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    else
    {
        Console.WriteLine("В указанной позиции стоит число: " + array[rowNumber -1, columnNumber -1]);
    }
}

int[,] GetArray(int rows, int columns, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}