/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int n = 0;

Console.Write("Введите натуральное число: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numberN);

//Проверяем на число
if (!boolN)
{
    Console.WriteLine("Введено неверное значение!");
    return;
}
else
{
    n = numberN;
    printAllNaturalNumbers(n);
}


//Рекурсия 
void printAllNaturalNumbers(int m)
{
    if (m == 1)
    {
        Console.Write(1);
        return;
    }
    else
    {
        Console.Write(m + ", ");
        printAllNaturalNumbers(m - 1);
    }
}
