// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
Console.Write("Введите размер массива ");
int Sz = int.Parse(Console.ReadLine());
int[] Arr = new int[Sz];
FilArr(Arr);// Заполнение массива
PrntArray (Arr);// Вывод массива
Console.WriteLine(($"Четных чисел {PosNegNum(Arr)}, Нечетных чисел {Arr.Length - PosNegNum(Arr)}"));

void PrntArray (int[] outArr)
{
                                            Console.WriteLine("В массиве: ");
    for (int j = 0; j < outArr.Length; j++)
    {
     Console.Write(($" {outArr[j]} "));   
    }
                                            Console.WriteLine();
}

void FilArr (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

int PosNegNum (int[] newArray) // Подсчет четных значений
{
    int Count = 0;
    foreach (int elem in newArray)
    {
        Count += elem%2 == 0 ? 1 : 0;
    }
    return  Count;
}