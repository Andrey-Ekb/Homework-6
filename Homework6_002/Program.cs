// Задать двухмерный массив следующим правилом Amn=m+n

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
                array[i, j] = i + j + 2;
            }
}
void PrintArray (double[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j < array.GetLength(1); j++)
        {     
            Console.Write(array[i,j].ToString("00.00")+ "  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

double[,]array=new double[m,n];

FillArray(array);
PrintArray(array);

Console.WriteLine();
