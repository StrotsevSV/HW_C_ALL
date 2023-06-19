// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("!1! - задайте массив вещественных чисел \n!2! - Определите максимальный и минимальный элементы массива \n!3! - Найдите разницу ме6жду максимальным и минимальным элементами массива");

Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
double [] array = new double [size];

for(int i = 0; i < size; i++){
    array[i] = new Random().Next(0,100) / 10.0;
Console.Write($"{array[i]} | ");
}
double max = array [0];
double min = array [0];

for(int i = 0; i < size; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i]; 
}
double raz = max - min;
Console.WriteLine($"\nМакс знач массива - {max}\nМин знач массива - {min}\nРазница макс и мин эл = {max - min}");







