//  Найти произведение двух матриц  
Console.Clear(); 
void FillArray(int[,] array) 
{ 
    int rowsLength = array.GetLength(0); 
    int columnsLength = array.GetLength(1); 
    Random rnd = new Random(); 
    for (int i = 0; i < rowsLength; i++) 
    { 
        for (int j = 0; j < columnsLength; j++) 
            array[i, j] = rnd.Next(1, 5); 
    } 
} 
void PrintArray(int[,] array) 
{ 
    int rowsLength = array.GetLength(0); 
    int columnsLength = array.GetLength(1); 
    for (int i = 0; i < rowsLength; i++) 
    { 
        for (int j = 0; j < columnsLength; j++) 
        { 
            Console.Write($"{array[i, j]}   "); 
 
        } 
        Console.WriteLine($""); 
    } 
} 
//void ArrayProduct(int[,] array, int[,] array2) 
//{ 
//    int[,] array3 = new int[2, 4]; 
//    int rowsLength = array.GetLength(0); 
//    int columnsLength = array.GetLength(1); 
//    for (int i = 0; i < rowsLength; i++) 
//    { 
//        for (int j = 0; j < columnsLength; j++) 
//        { 
//            array3[i, j] = array[i, j] * array2[i, j]; 
//            //Console.Write($"{array3[i, j]}  "); 
//        } 
//        //Console.WriteLine(""); 
//    } 
//} 
int[,] array = new int[2, 4]; 
FillArray(array); 
Console.WriteLine($"Матрица 1 "); 
PrintArray(array); 
int[,] array2 = new int[2, 4]; 
FillArray(array2); 
Console.WriteLine(); 
Console.WriteLine($"Матрица 2 "); 
PrintArray(array2); 
 
int[,] array3 = new int[2, 4]; 
int rowsLength = array.GetLength(0); 
int columnsLength = array.GetLength(1); 
    for (int i = 0; i < rowsLength; i++) 
    { 
        for (int j = 0; j < columnsLength; j++) 
        { 
            array3[i, j] = array[i, j] * array2[i, j]; 
            //Console.Write($"{array3[i, j]}  "); 
        } 
        //Console.WriteLine(""); 
    } 
//FillArray(array3); 
Console.WriteLine (); 
Console.WriteLine($"Произведение двух матриц: "); 
//ArrayProduct(array3);  
PrintArray(array3);