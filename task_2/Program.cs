int AskUser()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
try
{
    int op = int.Parse(Ask);
    if (op>0) return op;
    else {
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
else{
    Console.WriteLine("Введите верное число!");
    return AskUser();
}
}

double AskUser2()
{
Console.Write("Введите число: ");
string? Ask = Console.ReadLine();
if (Ask != null){
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
else{
    Console.WriteLine("Введите верное число!");
    return AskUser2();
}
}

int [,] FillArray(int [,] arrayToFill){
    for (int i = 0; i<arrayToFill.GetLength(0); i++){
        for (int j = 0; j<arrayToFill.GetLength(1); j++){
            arrayToFill[i,j] = new Random().Next(0,100);
        }
    }
    return arrayToFill;
}

void PrintArray(int [,] arrayToPrint){
    for (int i = 0; i<arrayToPrint.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToPrint.GetLength(1); j++){
            Console.Write(arrayToPrint[i,j]+ " ");
        }
    }
Console.WriteLine();
}

void RemoveColumnsAndRowsWithMinElement(int[,] arrayToChange){
    int col = 0, row = 0, min = int.MaxValue;
//string [,] tempArray = new string [arrayToChange.GetLength(0),arrayToChange.GetLength(1)];
    foreach (var temp in arrayToChange) {
        if (temp < min) {
            min = temp;
        }
    }
    for (int i = 0; i<arrayToChange.GetLength(0); i++){
        for (int j = 0; j<arrayToChange.GetLength(1); j++){
            if (arrayToChange[i,j]==min){
                row = i;
                col = j;
                Console.WriteLine();
                Console.Write(i+ " " + j + " ");
            }
        }
        }
    Console.WriteLine();
    for (int i = 0; i<arrayToChange.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToChange.GetLength(1); j++){
            if (i!=row && j!=col){
                Console.Write(arrayToChange[i,j] + " ");
            }
        }
        }
}

int [,] array = new int [AskUser(),AskUser()];
FillArray(array);
PrintArray(array);
RemoveColumnsAndRowsWithMinElement(array);
