// Написать программу, которая обменивает элементы первой строки и последней.
Console.Clear();

int ReadInt()
{
    Console.Write("Введите размер массива : ");
    return int.Parse(Console.ReadLine()!);
}

void FillArray (double[,] array)
{
    Random rnd=new Random();
        for (int i=0; i<array.GetLength(0); i++)
        
            for (int j=0; j < array.GetLength(1); j++)
            { 
                array[i,j] = rnd.NextDouble()*100;
            }
}

void Replicant (double[,] array)
{
for (int i = 0; i < array.GetLength(1); i++)
    {
        double value = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = value;
    }
}

void PrintArray (double[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j < array.GetLength(1); j++)
        {     
            Console.Write(array[i,j].ToString("000.00")+ "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

double[,]array=new double[m,n];

FillArray(array);
PrintArray(array);
Replicant (array);
PrintArray(array);

