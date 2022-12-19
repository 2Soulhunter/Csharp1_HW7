/*                          Домашнее задание к семинару 7 С#
Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.           */

int row = new Random().Next(3, 10);     // Генерируем кол-во строк в заданном диапазоне
int column = new Random().Next(3, 10);  // Генерируем кол-во столбцов в заданном диапазоне
int[,] matrix = new int[row, column];   // Создаём пустой массив
Console.WriteLine();
FillArray(matrix);                       // Запускаем функцию заполнения массива
PrintArray(matrix);                      // Выводим массив на экран
Console.WriteLine("Среднее арифметическое столбцов: ");
ColumnAverageCalc(matrix);              // Запускаем функцию вычисления ср. арифметического


void FillArray(int[,] matr)              // Функция заполнения массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 9);  // в заданном диапазоне
        }
    }
}

void PrintArray(int[,] matr)             // Функция вывода массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}

void ColumnAverageCalc(int[,] matr)  // Функция вычисления ср. арифметического
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.Write($"{sum / matr.GetLength(0)};\t");
    }
}