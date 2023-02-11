void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr, int quatroSize, int count, int circle)
{
    if (quatroSize > 0)
    {
    for (int j = circle-1; j < quatroSize; j++)
    {
        matr[0,j] = count;
        count++;
    }
    for (int i = circle; i < quatroSize; i++)
    {
        matr[i,(quatroSize - 1)] = count;
        count++;
    }
    for (int j = quatroSize - 2; j >= circle - 1; j--)
    {
        matr[(quatroSize - 1),j] = count;
        count++;
    }
    for (int i = quatroSize - 2; i > circle - 1; i --)
    {
        matr[i,0] = count;
        count++;
    } 
    quatroSize = quatroSize - 1;   
    circle = circle + 1;
    FillArray(matr, quatroSize, count, circle);
    }
}

Console.Clear();

int rows = 4;
int columns = 4;
int startNumber = 10;
int circle = 1;

int [,] array = new int [rows,columns];

FillArray(array, array.GetLength(1), startNumber, circle);
PrintArray(array);
