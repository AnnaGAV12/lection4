﻿//string[,] table = new string[2, 5];
//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"{table[rows, columns]}-");
//    }
//}   // по умолчанию string.Empty- строки пустые


int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); //принудительный переход на новую строку
    }
}

void FillArray(int[,] matr) // для заполнения рандомом
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1;10)
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);