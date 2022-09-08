/*-----------------------------------------------------------------------------------------
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
-----------------------------------------------------------------------------------------*/

double[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, cols];
    
    Random rnd = new Random();
    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = rnd.Next(minValue,maxValue+1) + rnd.NextDouble();
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j]>0)
                Console.Write($" {array[i,j]:f1} ");
            else
                Console.Write($"{array[i,j]:f1} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

double[,] newArr = CreateRandom2dArray();
Show2dArray(newArr);