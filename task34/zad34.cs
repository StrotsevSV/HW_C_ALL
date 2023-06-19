// Задача 34: 
// // Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine ("!1! - Задайте массив заполненный случайными положительными трёхзначными числами \n!2! - Покажите количество чётных чисел в массиве");

int[] FillArray(string massage){
    Console.Write(massage);
    int sum = 0;
    int size = int.Parse(Console.ReadLine());
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(100,1000);
            if(array [i]%2==0)
            {
                sum = sum + 1;
            }
        Console.Write($"{array [i]} | ");
    }
    Console.Write($"\nКолличество четных чисел массива:   {sum}");
    return array;
}

int[] array = FillArray("Введи размер массива: ");