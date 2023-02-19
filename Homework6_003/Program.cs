// В двухмерном массиве заменить элементы, у которых оба индекса четные на их квадраты.

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

void IndexEditing (double[,]array)
{
     for (int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j < array.GetLength(1); j++)
        {     
            if(i%2==0 && j%2==0) array[i,j]=array[i,j]*array[i,j];
            else array[i,j]=array[i,j];
        }
    }
}


void PrintArray (double[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    { 
        for (int j=0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(array[i,j].ToString("0000.00")+" | ");
                Console.ResetColor();
            }
            else Console.Write(array[i,j].ToString("0000.00")+ " | ");
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
IndexEditing (array);
PrintArray(array);

Console.WriteLine();
