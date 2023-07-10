//Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и 
//минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
Console.Write("Введите размер массива: ");
int szArray = int.Parse (Console.ReadLine());  //Определяем размер массива
double[] Arr = new double[szArray];     //Инициализация массива
FilRandAr(Arr);                         //Заполнение массива
outArray(Arr);                          //Вывод массива для контроля
Console.WriteLine($"Максимальный: {minMaxAr(Arr)[0]}");
Console.WriteLine($"Минимальный: {minMaxAr(Arr)[1]}");
Console.WriteLine($"Разность: {minMaxAr(Arr)[0] - minMaxAr(Arr)[1]}");


double[] minMaxAr(double[] array)//Возвращает массив с минимальным и максимальным значением
{
   double[] MxMnAr = new double[2];
     MxMnAr[0] = array[0];
    MxMnAr[1] = array[0];
    for (int pos = 0; pos < array.Length; pos++)
    {
        MxMnAr[0] = array[pos] > MxMnAr[0] ? array[pos] : MxMnAr[0]; //Ищем максимальное значени
        MxMnAr[1] = array[pos] < MxMnAr[1] ? array[pos] : MxMnAr[1]; //Ищем минимальное значение
    }
    return  MxMnAr;
}


void FilRandAr (double[] arr)
{
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = new Random().Next(-20,21);
       arr[i] = Math.Round((arr[i]/Math.Sqrt(2)),2);//для получения числа с запятой
    }
}

void outArray (double[] ar) // Просто вывод массива
{                                         
    for (int j = 0; j < ar.Length; j++) 
    {
        Console.Write(($"{ar[j]} | ")); 
    }
                                        Console.WriteLine();
}
