int AskUser()
{
    Console.Write("Введите число: ");
    string? Ask = Console.ReadLine();
    if (Ask != null)
    {
        try
        {
            int op = int.Parse(Ask);
            if (op > 0) return op;
            else
            {
                Console.WriteLine("Введите число > 0!");
                return AskUser();
            };
        }
        catch (Exception)
        {
            Console.WriteLine("Введите верное число!");
            return AskUser();
        }
    }
    else
    {
        Console.WriteLine("Введите верное число!");
        return AskUser();
    }
}

int[,] FillArray(int[,] arrayToFill)
{

    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arrayToFill[i, j] = new Random().Next(0, 100);
        }
    }
    return arrayToFill;
}

void PrintArray(int[,] arrayToPrint)
{

    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProdMatrix(int[,] op1, int[,] op2)
{
    int [,] resultMatrix = new int [op1.GetLength(0),op2.GetLength(1)];
    for (int i = 0; i < op1.GetLength(0); i++)
        for (int j = 0; j < op2.GetLength(1); j++)
        {
            for (int k = 0; k < op1.GetLength(1); k++)
                resultMatrix[i,j] += op1[i,k] * op2[k,j];
        }
    return resultMatrix;
}

int [,] array1 = new int[AskUser(),AskUser()];
FillArray(array1);
PrintArray(array1);
int [,] array2 = new int[AskUser(),AskUser()];
FillArray(array2);
PrintArray(array2);
PrintArray(ProdMatrix(array1,array2));