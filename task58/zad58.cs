// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("!1! - Задайте две матрицы\n!2! - Напишите программу, которая будет находить произведение двух матриц.");

int Prompt(string message)
{
    int result = 0;
        try
        {
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch{Console.WriteLine("ошибка функции Prompt");}
    return result;
}
int[,] FilMatrixRand(int row,int col,int min,int max)
{
    int[,] result = new int[row,col];
    Console.WriteLine($"\n-создан двумерный массив строк={row}|колонок={col}|наполнен числами от {min} до {max}");
        try
        {
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    result[i,j] = new Random().Next(min,max+1);
                }
            }
        }
        catch{Console.WriteLine("ошибка функции FilMatrixRand");}
    return result;
}
    
void PrintMatrix(int[,] result)
{
    try
    {
        for(int i=0;i<result.GetLength(0);i++)
        {
            for(int j=0;j<result.GetLength(1);j++)
            {
                
                Console.Write($"{result[i,j]} \t");
            }
                Console.WriteLine();
        }
    }
    catch{Console.WriteLine("ошибка функции GetTwoDecIntArrayAndPrint");}
}    
    
int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);  
    int cols1 = matrix1.GetLength(1);  
    int cols2 = matrix2.GetLength(1);  

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int[,] arrayA = FilMatrixRand(Prompt("\nВведите количество строк: "),
    Prompt("Введите количество колонок: "),
    Prompt("Введите количество минимум для рандомных чисел массива: "),
    Prompt("Введите количество максимум для рандомных чисел массива: "));
    
int[,] arrayB = FilMatrixRand(Prompt("\nВведите количество строк: "),
    Prompt("Введите количество колонок: "),
    Prompt("Введите количество минимум для рандомных чисел массива: "),
    Prompt("Введите количество максимум для рандомных чисел массива: "));
    
PrintMatrix(arrayA);
Console.WriteLine();
PrintMatrix(arrayB);

Console.WriteLine();
PrintMatrix(MultiplyMatrix(arrayA,arrayB));

