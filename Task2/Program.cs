// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// метод создания и заполнения двумерного массива
int[,] GenerateMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

// метод вывода массива
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

// Метод поиска строки с минимальной суммой 
int FindSmallestAmountRow(int[,] array)
{
    int minSumRow = 0, minIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i, j];
        }
        if (minSumRow == 0) minSumRow = sumElement;
        if (sumElement < minSumRow)
        {
            minSumRow = sumElement;
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array = GenerateMatrix(3, 4);
PrintMatrix(array);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {FindSmallestAmountRow(array)}");