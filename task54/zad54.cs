// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2




int[,] FillArray()
{
    Console.Write("\n Введиту кол-во строк: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("\n Введите кол-во колонок: ");
    int col = int.Parse(Console.ReadLine());

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


int[,] Sortir(int[,] array)
{
//-переход от строки массива к строке
     for(int row=0;row<array.GetLength(0);row++)//-переход от строки массива к строке
    {
        for(int col_a=0;col_a<array.GetLength(1);col_a++)
        {
            for(int col=0;col<array.GetLength(1)-1;col++)
            {
                int temp = array[row,col];
                if(array[row,col]<array[row,col+1])
                {
                    array[row,col] = array[row,col+1];
                    array[row,col+1] = temp;
                }
            }
        }
    }//-переход от строки массива к строке
    return array;
} 



int[,] PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} | ");
        }
    Console.WriteLine();
    }
   return array;
}


Console.Clear();
Console.WriteLine("!1! - Задайте двумерный массив\n!2! - Отсортируйте по убыванию строки массива");

int[,] mas = FillArray();
Console.WriteLine("razdelitel");

mas = Sortir(mas);

mas=PrintArray(mas);
