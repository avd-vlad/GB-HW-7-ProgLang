/*-----------------------------------------------------------------------------------------
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
-----------------------------------------------------------------------------------------*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max+1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();

    }
    Console.WriteLine();

}

double[] AvgByCol(int[,] arr)
{
    double[] avg = new double[arr.GetLength(1)];
    for(int i=0; i < arr.GetLength(1); i++)
    {
        avg[i] = 0;
        for(int j=0; j < arr.GetLength(0); j++)
            avg[i] += arr[j,i];
        avg[i] /= (double) arr.GetLength(0);
    }
    return avg;
}
void ShowAvg(double[] arr)
{
    Console.WriteLine("Average per every column:");
    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]:f1}]");
        else
            Console.Write($"{arr[i]:f1} ");
    Console.WriteLine();    
}

int[,] newArr=CreateRandom2dArray();
Show2dArray(newArr);
ShowAvg(AvgByCol(newArr));