// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

int ReadInt(string text) //Вводим значения строк и столбцов
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols) // Генерируем матрицу
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(3, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Выводим матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void MinimumSumElelements(int[,] array) // Вычисление строки с минимальной суммой элементов
{
    int minSum = 0;
    int minIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements += array[i, j];
        }
        if (i == 0)
        {
            minSum = sumElements;
        }
        else if (sumElements < minSum)
        {
            minSum = sumElements;
            minIndex = i;
        }
    }
    System.Console.WriteLine($"Строка {minIndex + 1} с наименьшей суммой элементов = {minSum}");
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

int[,] myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();
MinimumSumElelements(myMatrix);
