/*                          Домашнее задание к семинару 7 С#
задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Например:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9                */

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] matrix = new double[m, n];      // Создаём пустой массив
FillArray(matrix);                        // Запускаем функцию заполнения массива
PrintArray(matrix);                       // Выводим массив на экран


void FillArray(double[,] matr)            // Функция заполнения массива случайными числами
{
    Random Rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(Rand.Next(-100, 100) / 10.0);
        }
    }
}

void PrintArray(double[,] matr)           // Функция вывода массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4}\t");
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}