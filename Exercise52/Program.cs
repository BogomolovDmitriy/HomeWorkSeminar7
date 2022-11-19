/*
Задача 52. 
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] newArray = GetArray(4, 4);
PrintDoubleArray(newArray);
Console.WriteLine("Среднее арифметическое по столбцам: ");
PrintSimpleArray(ArithmeticMeanEveryOneColumn(newArray));
Console.WriteLine();

double[] ArithmeticMeanEveryOneColumn(int[,] array)
{
    double[] arithmeticMeanItemColumn = new double[array.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumItemColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumItemColumn += array[j, i];
        }
        arithmeticMeanItemColumn[i] = sumItemColumn / array.GetLength(0);
    }
    return arithmeticMeanItemColumn;
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

void PrintDoubleArray(int[,] array)
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

void PrintSimpleArray(double[] array)
{
    Console.Write(string.Join("\t", array));
}