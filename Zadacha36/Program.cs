//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArr = int.Parse(Console.ReadLine());
int[] Arr = new int[sizeArr];
FillingAr (Arr); //Заполнение массива
Console.WriteLine("В массиве: ");
outArray(Arr);// Вывод массива
Console.WriteLine($"Сумма значений чисел стоящих на нечетных позициях составляет: {sumNegativPos(Arr)}");

void outArray (int[] ar)
{                                         
    for (int j = 0; j < ar.Length; j++) Console.Write(($"{ar[j]}, ")); 
    
                                        Console.WriteLine();
}

int sumNegativPos (int[] arr)
{
    int Sum = 0;
    for (int i = 1; i < arr.Length; i=i+2) Sum += arr[i];
    return Sum;
}

void FillingAr (int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(0,16);
    }
}