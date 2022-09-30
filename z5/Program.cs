// // ============== Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.Clear();
// Console.Write("Задайте количество элементов массива: ");
// int s = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(s);
// Console.WriteLine(String.Join(" ", array));    //выводим в строку через пробел элементы массива 
// int col = 0;


// for (int i = 0; i < array.Length; i++)
// {
//     if ((array[i] % 2) == 0)                  // если при делении элемента массива на 2 остаток от деления равен 0 
//     {
//         col += 1;                             // увеличиваем на 1, тем самым подсчитали количество четных чисел 
//     }
// }
// Console.WriteLine($"Количество четных чисел в массиве равно {col}");


// int[] GetArray(int size)  //метод генерации массива случайных чисел с указанием размера массива, от 100 до 999)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(100, 1000);
//     }
//     return res;
// }






// //============ Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Задайте количество элементов массива: ");
int s = int.Parse(Console.ReadLine()!);
int[] array = GetArray(s);
Console.WriteLine(String.Join(" ", array));          //выводим в строку через пробел элементы массива 
int summ = 0;


for (int i = 0; i < array.Length; i++)
{
    if ((i % 2) != 0)                               // если при делении номера элемента массива на 2 остаток от деления не равен 0 (т.е. элемент нечетный)
    {
        summ += array[i];                           // считаем сумму элементов
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {summ}");


int[] GetArray(int size)  //метод генерации массива случайных чисел От 1 до 999)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 1000);
    }
    return res;
}





// ============ Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Clear();
// Console.Write("Задайте количество элементов массива: ");
// int s = int.Parse(Console.ReadLine()!);
// double[] array = GetArray(s);
// Console.WriteLine(String.Join(" | ", array.Select(n => $"{n:F2}")));         //выводим в строку через пробел элементы массива 
// Console.Write($"Разница между максимальным и минимальным элементом массива, равна: {Diff_Array(array):F2}");  //выводим разность max-min


// double[] GetArray(int size)  //метод генерации массива случайных чисел От 1 до 99)
// {
//     double[] res = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().NextDouble() + new Random().Next(1, 100);
//     }
//     return res;
// }


// double Diff_Array(double[] in_array)  //метод нахождения разницы максимального и минимального элемента массива
// {
//     double min = in_array[0];
//     double max = in_array[0];

//     for (int i = 0; i < in_array.Length; i++)
//     {
//         if (in_array[i] < min)
//         {
//             min = in_array[i];
//         }
//         if (in_array[i] > max)
//         {
//             max = in_array[i];
//         }
//     }
//     double diff = max - min;
//     return diff;
// }