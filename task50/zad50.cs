// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Clear();
//-postanovka zadachi
Console.WriteLine("!1! - Напишите прогу, которая принимает поз эл в двумерном массиве\n!2! - Возвращант знач этого элемента\n!3! - Выводит сообщение об ошибке");
//-sozdat massiv


int Prompt(string message)
{

    int result = 0;
        try
        {
            Console.Write(message);
            result = int.Parse(Console.ReadLine());
        }
        catch {Prompt("ошибка ввода, введите заново");}
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
                Console.Write($"{array[i,j]} | ");
            }
        Console.WriteLine();
        }
    return array;
}

int[,] array = FillArray(Prompt("Введи строку: "),Prompt("Введи колонку: "));

// вызвать метод, который примит элементы двумерного массива на проверку наличия в массиве
int user_row = Prompt("введи строку массива: ");
int user_col = Prompt("Введи колонку массива: ");
    if (array.GetLength(0) < user_row & array.GetLength(1) < user_col) 
    {
        Console.Write($"[{user_row},{user_col}]-> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"{array[user_row-1,user_col-1]}");
    }
