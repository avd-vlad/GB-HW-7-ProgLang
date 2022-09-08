/*-----------------------------------------------------------------------------------------
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
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
void ShowArrayElement(int[,] arr, int row, int col)
{
    if(row >= arr.GetLength(0) || col >= arr.GetLength(1))
        Console.WriteLine($"There is no element with indexes [{row},{col}]");
    else
        Console.WriteLine($" X[{row},{col}] = {arr[row,col]}");

}


int[,] newArr=CreateRandom2dArray();

Show2dArray(newArr);
Console.Write($"Please enter the row number of the element you want to be shown (0..{newArr.GetLength(0)-1}): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Please enter the col number of the element you want to be shown (0..{newArr.GetLength(1)-1}): ");
int col = Convert.ToInt32(Console.ReadLine());

ShowArrayElement(newArr, row, col);
