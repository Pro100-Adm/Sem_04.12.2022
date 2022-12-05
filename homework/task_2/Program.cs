// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 5 2 6 7 
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
 
int m = 3; 
int n = 3; 
int[,] array = new int[m, n]; 
 
PrinArray(FillArray(array)); 
 
Console.WriteLine($"номер строки с наименьшей суммой элементов равен - {SummStringElementsArray(array)}"); 
 
int[,] FillArray(int[,] arr) 
{ 
 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            arr[i, j] = new Random().Next(0, 100); 
 
        } 
    } 
    return arr; 
} 
 
int SummStringElementsArray(int[,] ar) 
{ 
    Dictionary<int, int> summ = new Dictionary<int, int>();
    for (int i = 0; i < ar.GetLength(0); i++) 
    { 
        int temp = 0; 
 
        for (int j = 0; j < ar.GetLength(1); j++) 
        { 
            temp += ar[i, j]; 
 
        } 
        summ.Add(i,temp); 
    } 
    
    summ = summ.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    List<int> keyList = new List<int>(summ.Keys);
    int result = keyList[0]+1;
    return result;
} 
 
 
 
 
void PrinArray(int[,] ar) 
{ 
 
    for (int i = 0; i < ar.GetLength(0); i++) 
    { 
        for (int j = 0; j < ar.GetLength(1); j++) 
        { 
            Console.Write($"{ar[i, j]} "); 
 
        } 
        Console.WriteLine(""); 
    } 
    Console.WriteLine(""); 
}