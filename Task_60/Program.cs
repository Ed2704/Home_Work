﻿/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Clear();
Console.WriteLine();
int[,,] array = new int[2,2,2];
FillArray(array);
PrintArray(array);

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



void FillArray(int[,,] array)
{
    Random generator = new Random();
    int num = 0;
    bool isUnique = true;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                {
                    num = generator.Next(10, 99);
                    isUnique = Find(array, num);

                } while (isUnique);
                array[i, j, k] = num;
            }
        }
    }
}

bool Find(int[,,] array, int num)
{
    bool isUnique = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                if (array[i, j, k] == num)
                {
                    isUnique = true;
                    break;
                }
            }
        }
    }
    return isUnique;
}