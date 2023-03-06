// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] GetNumber(string text) //Ввод данных
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}


void PrintArray(int[] arr) //Вывод данных 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int CheckNumbers(int[] array) //Подсчет введенных чисел > 0 
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}


int[] arr = GetNumber("Введите несколько чисел <0, =0 и >0 через пробел: ");

PrintArray(arr);

System.Console.WriteLine($"Число введенных положительных чисел = {CheckNumbers(arr)}");


