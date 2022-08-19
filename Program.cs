// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] array = new int [10];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     if (array[i] %2 == 0) count += 1;
// }
// Console.WriteLine($"[{String.Join(";" , array)}]");
// Console.WriteLine($"количество четных чисел в массиве равно {count}");

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int [] array = new int [10];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//      array[i] = new Random().Next(1,100);
//      if (i %2 == 0) count += array[i];
// }
// Console.WriteLine($"[{String.Join(";" , array)}]");
// Console.WriteLine($"сумма элементов на нечетных позициях равна {count}");

// задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double [] array = new double [10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,100); 
// }
// Console.WriteLine($"[{String.Join(";" , array)}]");
// double min = array[0];
// double max = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max) max = array[i];
//     if (array[i] < min) min = array[i];
// }
// double diff = max - min;

// Console.WriteLine($"разница между максимальным и минимальным элементов равна {diff}");