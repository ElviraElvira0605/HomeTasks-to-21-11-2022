// Задача 54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

    // Сортировка всех строк по убыванию
    static void SortRowsAsc(ref int[,] matr, int m, int n)
    {
        // Цикл по всем строкам матрицы
        for (int i = 0; i < m; i++)
        {
            // Сортировка строки по убыванию
            for (int j = 0; j < n - 1; j++)
                for (int k = j + 1; k < n; k++)
                    if (matr[i, j] < matr[i, k])
                    {
                        int tmp = matr[i, j];
                        matr[i, j] = matr[i, k];
                        matr[i, k] = tmp;
                    }
        }
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
        Console.WriteLine("Матрица до сортировки:");
        Print(matr, m, n);
        // Сортировка строк
        SortRowsAsc(ref matr, m, n);
        // Вывод выходной матрицы
        Console.WriteLine("Матрица после сортировки:");
        Print(matr, m, n);
    }
}









