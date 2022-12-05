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

double AskUser2()
{
    Console.Write("Введите число: ");
    string? Ask = Console.ReadLine();
    if (Ask != null)
    {
        try
        {
            double op = double.Parse(Ask);
            return op;
        }
        catch (Exception)
        {
            Console.WriteLine("Введите верное число!");
            return AskUser2();
        }
    }
    else
    {
        Console.WriteLine("Введите верное число!");
        return AskUser2();
    }
}

int[,,] FillArray(int[,,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToFill.GetLength(2); k++)
            {
                int value = new Random().Next(10, 100);
                arrayToFill[i, j, k] = value;
            }
        }
    }
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToFill.GetLength(2); k++)
            {
                int value = new Random().Next(10, 100);
                arrayToFill[i, j, k] = value;
                if (!Validator(arrayToFill, value))
                {
                    int newValue = new Random().Next(10, 100);
                    arrayToFill[i, j, k] = newValue;
                }
            }
        }
    }
    return arrayToFill;
}

bool Validator(int[,,] arrayToValidate, int value)
{
    int [,,] count = new int[arrayToValidate.GetLength(0),arrayToValidate.GetLength(1),arrayToValidate.GetLength(2)];
    for (int i = 0; i < arrayToValidate.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToValidate.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToValidate.GetLength(2); k++)
            {
                if (arrayToValidate[i, j, k] == value)
                {
                    count[i,j,k] ++;
                }
            }
        }
    }
    for (int i = 0; i < count.GetLength(0); i++)
    {
        for (int j = 0; j < count.GetLength(1); j++)
        {
            for (int k = 0; k < count.GetLength(2); k++)
            {
                if (count[i, j, k] >1)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintArrayWithIndexes(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.WriteLine(arrayToPrint[i, j, k] + " (" + i + "," + j + "," + k + ")");
            }
        }
    }
    Console.WriteLine();
}

int[,,] array = new int[AskUser(), AskUser(), AskUser()];
FillArray(array);
PrintArrayWithIndexes(array);
