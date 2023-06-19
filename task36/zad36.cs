// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("!1! - write [] array, with random digits \n!2! - loock fo elements sum on odd pozitions");

int[] FillArray(string massage){ // метод - принимает сообщение, выводит его и заполняет одномерный массив случайными числами
    Console.Write(massage);
    int sum = 0;
    string nechet = "";
    int size = int.Parse(Console.ReadLine());
    int [] array = new int [size];
    for(int i = 0; i < size; i++){
        array [i] = new Random().Next(0,10);
        if (i%2!=0){
            sum = sum + array[i];
            nechet="нечётное";
        }
        else
        {
            nechet="чётное  ";
        }
        Console.WriteLine($"массив[{i}]={array[i]}   |   индекс={i} -{nechet}  |   сумма нечетных: {sum}");
    }
    return array;
}

int[] array = FillArray("Vvedy razmer massiva: ");
// Console.Write("Введите размер массива: "); // вывод сообщения пользователя
// int size = int.Parse(Console.ReadLine()); // считывание данных пользователя и присвоение переменной size
// int[] array = new int [size]; // обозначение размера массива
// for(int i = 0; i < size; i++){  // цикл на заполнение индекса массива до указанного размера
//     array [i] = new Random().Next(0,10); // заполнение массива рандомными числами от 0-10
//     Console.Write($"{array [i]} | ");    // выводит массив (одномерный)
// }
