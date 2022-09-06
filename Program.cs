using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление переменных
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine()); 
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;//повороты
            int visits = n;//проверка выхода за массив
           //цикл по расчету спиральных чисел
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0)
                {
                    visits = n * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    //замена мест элементов
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                  
                }
                col += dx;
                row += dy;
                
            }
            //вывод матрицы в консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
