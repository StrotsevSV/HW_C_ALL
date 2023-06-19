// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int row = 2;
int col = 3;
double[,] array = new double [row, col];

for(int i = 0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {
        array[i,j] = new Random().Next(0,100) / 10.0;
    Console.Write($"{array[i,j]}  |  ");
    }
    Console.WriteLine();
}

