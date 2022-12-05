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

void PrintArray(int [,] arrayToPrint){
    for (int i = 0; i<arrayToPrint.GetLength(0); i++){
        Console.WriteLine();
        for (int j = 0; j<arrayToPrint.GetLength(1); j++){
            Console.Write(arrayToPrint[i,j]+ "\t");
        }
    }
Console.WriteLine();
}

void FillArraySpirally(int [,] arrayToFill){
    int width = arrayToFill.GetLength(1), height = arrayToFill.GetLength(0);
    int iBegin = 0, iFinal = 0, jBegin = 0, jFinal = 0;             //Инициализируем отступы от краёв прямоугольника
    int i = 0, j = 0, currentElement = 1;
    while(currentElement<= width*height){                             
        arrayToFill[i,j] = currentElement;
        if (i == iBegin && j < width - jFinal - 1)                    //Если можно пойти вправо
            j++;                                                      //Идём вправо
        else if (j == width - jFinal - 1 && i < height - iFinal - 1)  //Иначе если можно пойти вниз
            i++;                                                      //Идём вниз
        else if (i == height - jFinal - 1 && j > jBegin)              //Иначе если можно пойти влево
            j--;                                                      //Идём влево
        else                                                          //Иначе
            i--;                                                      //Идём вверх

    if ((i == iBegin + 1) && (j == jBegin) && (jBegin != width - jFinal - 1)){ //Если находимся на второй строке в первом столбце 
            iBegin++;                                                          //Увеличиваем отступы от краёв прямоугольника
            iFinal++;
            jBegin++;
            jFinal++;
        }
        currentElement++;
    }
PrintArray(arrayToFill);
}

int [,] array = new int [AskUser(), AskUser()]; 
FillArraySpirally(array);