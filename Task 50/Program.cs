// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

const int rows = 3; //* Введите в const Количество строк
const int cols = 4; //* Введите в const Количество столбцов
const int i = 2;    //* Введите в const index строки
const int j = 2;    //* Введите в const index столбца

int[,] GenerateMatrix(int rows, int cols) // Задание рандомного двумерного массива
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); // "\t" Табуляция, позволяет сделать правильные отступы*\\
        }
        System.Console.WriteLine();
    }
}

void SearchNumbers(int[,] matrix)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        System.Console.WriteLine($"Число в массиве с индексами {i} и {j} есть: {matrix[i, j]}");
    }
    else
    {
        System.Console.WriteLine($"Числа в массиве с индексами {i} и {j} нет");
    }
}

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
SearchNumbers(myMatrix);
System.Console.WriteLine();
