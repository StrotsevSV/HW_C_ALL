// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("!1! - Задайте прямоугольный двумерный массив\n!2! - Напишите программу, которая будет находить строку с наименьшей суммой элементов");

int[,] FullArray(int row, int col)
{
    int[,] array = new int[row,col];
    for(int i = 0; i < row; i++) 
    {
        for(int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i,j]} |");
        }
    Console.WriteLine();
    }
return array;
}

int Prompt(string message)
{
int result = 0;
    try
    {
       Console.Write(message);
       result = int.Parse(Console.ReadLine());
    }
    catch
    {
        Prompt("ошибка ввода, введите заново: ");
    }
    return result;
}

int row = Prompt("Введи кол стр: ");
int col = Prompt("Введи кол кол: ");
if (row < col || col < row)
{
    int[,] mas = FullArray(row,col);
    
    row = mas.GetLength(0);
    col = mas.GetLength(1);
    int minRowSum = int.MaxValue;
    int minRowInd = -1;
    for (int i = 0; i < row; i++)
    {
        int Sum = 0;
        for (int j = 0; j < col; j++)
        {
            Sum += mas[i, j];
        }
        if (Sum < minRowSum)
        {
            minRowSum = Sum;
            minRowInd = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowInd+1}");
        for (int j = 0; j < col; j++)
        {
            Console.Write(mas[minRowInd, j]+" ");
        }
    }
else
{
    Console.WriteLine("Все плохо, переделывай");
}




