// Задача 56:  Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов 
// в каждой строке
// и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

using System;

class Program
{
    // Ввод матрицы размера m x n
    static int[,] Input(int m, int n)
    {
        int[,] matr = new int[m, n];
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
        {
            // Цикл по всем столбцам матрицы
            for (int j = 0; j < n; j++)
            // Ввод числа
            {
                Console.Write($"Введите matr[{i + 1}, {j + 1}]: ");
                matr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matr;
    }

    // Вывод матрицы на экран
    static void Print(int[,] matr, int m, int n)
    {
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
        {
            // Цикл по всем столбцам матрицы
            for (int j = 0; j < n; j++)
                // Печать числа
                Console.Write($"{matr[i, j],4} ");
            // Переход на новую строку
            Console.WriteLine();
        }
    }

    // Получение массива сумм всех строк
    static int[] SumRows(int[,] matr, int m, int n)
    {
        int[] sums = new int[m];
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
        {
            // Вычисление суммы
            sums[i] = 0;
            // Цикл по всем столбцам матрицы
            for (int j = 0; j < n; j++)
                sums[i] += matr[i, j];
        }
        return sums;
    }

    // Поиск строки с минимальной суммой
    static int RowWithMinSum(int[] sums, int m)
    {
        // Минимум инициализируется суммой первой строки
        int row = 0;
        int min = sums[0];
        // Сравнение остальных строк
        for (int i = 1; i < m; i++)
            // Проверка на минимум суммы
            if (sums[i] < min)
            {
                row = i;
                min = sums[i];
            }
        return row;
    }

    // Основная программа
    static void Main()
    {
        // Ввод целого числа m
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        // Ввод целого числа n
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        // Создание и заполнение матрицы
        int[,] matr = Input(m, n);
        // Вывод исходной матрицы
        Console.WriteLine("Матрица:");
        Print(matr, m, n);
        // Нахождение суммы строк
        int[] sums = SumRows(matr, m, n);
        // Нахождение строки с минимальной суммой
        int row = RowWithMinSum(sums, m);
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row + 1}-я строка");
    }
}




