// Задача 60: Сформируйте трёхмерный массив 
// из двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int ReadInt(string text) //Вводим значения строк, столбцов и диагоналей
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

DateTime dt = DateTime.Now; //Время работы нашего кода

int[,,] GenerateMatrix(int rows, int cols, int diagonals) // Генерируем 3х мерный массив
{
    Random rand = new Random();
    int[,,] matrix = new int[rows, cols, diagonals];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix) // Выводим массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write(matrix[i, j, k] + "\t");
            }

        }
        System.Console.WriteLine();
    }
}

void OutputArrayWithIndex(int[,,] array) // Выводим числа массива с указанием их индекса
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine("Индекс массива: [{0}, {1}, {2}] = {3}", i, j, k, array[i, j, k]);
            }
        }
    }
}


int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int diagonals = ReadInt("Введите количество диагоналей: ");

int[,,] myMatrix = GenerateMatrix(rows, cols, diagonals);
PrintMatrix(myMatrix);
System.Console.WriteLine();
OutputArrayWithIndex(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"Время работы нашего кода = {(DateTime.Now - dt).TotalMilliseconds}");
