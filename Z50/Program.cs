/*                          Домашнее задание к семинару 7 С#
Задача 50: Напишите программу, которая на вход принимает значение элемента в двумерном
массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет                */

int m = new Random().Next(3, 10);   // Генерируем кол-во строк в заданном диапазоне
int n = new Random().Next(3, 10);   // Генерируем кол-во столбцов в заданном диапазоне
int[,] matrix = new int[m, n];      // Создаём пустой массив
FillArray(matrix);                  // Запускаем функцию заполнения массива
FindNumber(matrix);                 // Запускаем функцию поиска числа в массиве
Console.WriteLine();
PrintArray(matrix);                 // Выводим массив на экран (для наглядности)

void FillArray(int[,] matr)         // Функция заполнения массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-9, 9);  // в заданном диапазоне
        }
    }
}

void FindNumber(int[,] matr)        // Функция поиска числа в массиве
{
    Console.WriteLine("Введите искомое число: ");
    int NumX = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int row = 0;
    int column = 0;
    bool checkFind = false;
    int i = 0;
    int j = 0;
    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == NumX)
            {
                row = i;
                column = j;
                checkFind = true;
                break;
            }

        }
    }
    if (checkFind == true)
    {
        Console.WriteLine($"Искомое число:  {NumX}  расположено по индексу: [{row}, {column}]");
    }
    else
    {
        Console.WriteLine($"Искомое число:  {NumX}  в массиве не найдено!");
    }
}

void PrintArray(int[,] matr)        // Функция вывода массива на экран
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