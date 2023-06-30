// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }


// void EvenNumber(int[] array)
// {
//     int cont = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//         {
//             cont++;
//         }
//     System.Console.WriteLine($"number of even numbers -> {cont}");
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// PrintArray(CreateRandomArray(size));
// EvenNumber(CreateRandomArray(size));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,50);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int SumElementNegative(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) 
//         sum = sum + array[i];
//     }
//     return sum;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size);
// PrintArray(array);
// System.Console.WriteLine($" sum of elements in odd positions -> {SumElementNegative}(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateRandomArray(int size)
// {
//     double[] array2 = new double[size];    //  numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().NextDouble();
//         array2[i] = new Random().Next(1, 50);
//         array[i] = array2[i] + array[i];
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(Math.Round(array[i], 2) + "  ");
//     }
//     System.Console.WriteLine();
// }

// double DifferenceBetweenNum(double[] array)
// {
//     double diff = 0;
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//             max = array[i];

//         if (array[i] < min)
//             min = array[i];

//     }
//     return diff = max - min;
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// double[] array = CreateRandomArray(size);
// PrintArray(array);
// double ress = DifferenceBetweenNum(array);
// System.Console.WriteLine($"Difference {Math.Round(ress, 2)}");

