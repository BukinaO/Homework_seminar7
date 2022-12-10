// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = ReadInt("Введите количество строк массива: ");
int n = ReadInt("Введите количество столбцов массива: ");
int[,] numbers = new int[m, n];


FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

for(int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    double result = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];            
    }
    result = sum/m;
    Console.WriteLine(String.Format("{0:0.0}",result));
}

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

