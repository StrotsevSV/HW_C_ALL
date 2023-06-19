// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("!1! - Задайте двумерный массив из целых чисел \n!2! - Найдите среднее арифметическое элементов в каждом столбце");

int Prompt(string message)
{
    int result = 0;
    try
    {
        Console.Write(message);
        result = int.Parse(Console.ReadLine());
    }
    catch{Prompt("ошибка ввода, вводи заново");}
    return result;
}

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row,col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i,j]} \t ");
        }
        Console.WriteLine();
    }
return array;
}

int [,] arr = FillArray(Prompt("Веди кол-во строк: "),Prompt("Веди кол-во столбцов: "));


double[] sred =  new double[arr.GetLength(1)];
double a = 0.0;
Console.WriteLine();

    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            a = arr[i,j] ;
            sred[j] = sred[j] + (a / arr.GetLength(1));
        }
        Console.Write($"{Math.Round(sred[j],2)}\t");
    }


// 1 4 7 2
// 5 9 2 3
// 8 4 2 4