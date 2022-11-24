// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить
//  произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

    // Произведение матриц A (m x n) и B (n x k)
    static int[,] Product(int[,] A, int[,] B, int m, int n, int k)
    {
        int[,] C = new int[m, k];
        for (int i1 = 0; i1 < m; i1++)
            for (int i2 = 0; i2 < k; i2++)
            {
                C[i1, i2] = 0;
                for (int i3 = 0; i3 < n; i3++)
                    C[i1, i2] += A[i1, i3] * B[i3, i2];
            }
        return C;
    }
    
    // Основная программа
    static void Main()
    {
        /*
         * Перемножение матриц размера m x n и n x k
         */

        // Ввод целого числа m
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        // Ввод целого числа n
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        // Ввод целого числа k
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        // Создание и заполнение матрицы A
        int[,] A = Input(m, n);
        // Вывод исходной матрицы
        Console.WriteLine("Матрица A:");
        Print(A, m, n);

        // Создание и заполнение матрицы b
        int[,] B = Input(n, k);
        // Вывод исходной матрицы
        Console.WriteLine("Матрица B:");
        Print(B, n, k);

        // Вычисление произведения
        int[,] C = Product(A, B, m, n, k);
        // Вывод произведения
        Console.WriteLine("Матрица C = AxB:");
        Print(C, m, k);
    }
}

