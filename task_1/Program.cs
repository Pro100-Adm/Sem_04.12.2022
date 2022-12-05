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

string [,] FillArray(string[,] arrayToFill){
    for (int i = 0; i<arrayToFill.GetLength(0); i++){
        for (int j = 0; j<arrayToFill.GetLength(1); j++){
            arrayToFill[i,j] = Convert.ToString(new Random().Next(0,100));
        }
    }
    return arrayToFill;
}

void PrintArray(string [,] arrayToPrint){
    for (int i = 0; i<arrayToPrint.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToPrint.GetLength(1); j++){
            if (arrayToPrint[i,j]!=null) Console.Write(arrayToPrint[i,j]+ " ");
            if (arrayToPrint[0,0]== "Операция невозможна!"){
            Console.WriteLine(arrayToPrint[0,0]);  
            break;  
            }
        }
    }
Console.WriteLine();
}

string [,] ChangeColumnsWithRows(string[,] arrayToChange){
string [,] tempArray = new string [arrayToChange.GetLength(0),arrayToChange.GetLength(1)];
try{
    for (int i = 0; i<arrayToChange.GetLength(0); i++){
        for (int j = 0; j<arrayToChange.GetLength(1); j++){
            tempArray[i,j] = Convert.ToString(arrayToChange[j,i]);
        }}}
        catch(Exception){
            tempArray[0,0] = "Операция невозможна!";
    }
    return tempArray;
}

string [,] array = new string [AskUser(),AskUser()];
FillArray(array);
PrintArray(array);
PrintArray(ChangeColumnsWithRows(array));