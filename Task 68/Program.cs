/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int n = 0;
int m = 0;

int n = 0;
int m = 0;

Console.Write("Введите первое значение: ");
bool boolN = int.TryParse(Console.ReadLine(), out int numberN);
Console.Write("Введите второе значение: ");
bool boolM = int.TryParse(Console.ReadLine(), out int numberM);

//Check 
if (boolN && boolM)
{
    n = numberN;
    m = numberM;
    // функция Аккермана
    int ackermanFunction(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return ackermanFunction(n - 1, 1);
        else
            return ackermanFunction(n - 1, ackermanFunction(n, m - 1));
    }
    int result = ackermanFunction(n, m);
    Console.WriteLine($"A({n},{m}) = {result}");
}

else
{
    Console.WriteLine("Не верно введены значения! Введите число!");
}
