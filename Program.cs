/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int m, n, pozition;
Console.WriteLine("Введите количество строк массива");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите количество столбцов массива");
int.TryParse(Console.ReadLine(), out n);
int [,] array = new int [m,n]; 
for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j]=new Random().Next(10);
        
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++){
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию элемента который вы ищите");
int.TryParse(Console.ReadLine(), out pozition);
if (pozition<=array.Length){
    Console.WriteLine($"{array[(pozition-1)/array.GetLength(1),(pozition-1)%array.GetLength(1)]} - это число с указанной позицией");
}
else{Console.WriteLine("Такого числа нет в массиве");}