/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*double [,] Fillarray (int row, int column,int minVal, int maxVal)
{
    double [,] fillarray = new double [row, column];
    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            fillarray [i,j]= Math.Round((new Random().Next(minVal,maxVal))+(new Random().NextDouble()),2);
        }
    }
    return fillarray;
}
void PrintArray (double [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

}
Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input min possible value: ");
int minsVal= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input max possible value: ");
int maxsVal= Convert.ToInt32 (Console.ReadLine());

double [,] fillarray= Fillarray ( rows,  columns, minsVal,  maxsVal);
PrintArray(fillarray);
*/
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int [,] Fillarray(int row, int column)
{
    int [,] fillarray = new int [row, column];
    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            fillarray [i,j]= new Random().Next (1, 10);
        }
    }
    return fillarray;
}

void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

}

void NewArray (int [,] array)

{
Console.Write (" Input value of row: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input value  of column: ");
int columns= Convert.ToInt32 (Console.ReadLine());
int positionrow=0;
int positioncolumn=0;
    
    for (int i=0; i< array.GetLength(0); i++)
    {                      
        for (int j=0; j< array.GetLength(1); j++)
        {
            if (i==rows-1 && j ==columns-1)
            {
                positionrow=i;
                positioncolumn=j;                
            }
        }
    } 
    if ( rows >array.GetLength(0)|| columns > array.GetLength(1)||rows <1|| columns <1)
    {
       Console.Write ($" for the given values,  is not element in the array");   
    } 
    else
    {
    Console.Write ($" element in array {array[positionrow,positioncolumn]}"); 
    }
}
int [,] fillarray= Fillarray(3,4);
PrintArray(fillarray);
NewArray(fillarray);


/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*int [,] Fillarray(int row, int column)
{
    int [,] fillarray = new int [row, column];
    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            fillarray [i,j]= new Random().Next (1, 10);
        }
    }
    return fillarray;
}

void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

}

void NewArray ( int [,] array) 
{
   
   double [] array01= new double [array.GetLength(1)];
  
    for (  int j=0; j< array.GetLength(1); j++)
    {
         double sum=0;
        
        for (int i=0; i< array.GetLength(0); i++)
        {           
           sum =sum+array[i,j]; 
           double count=(sum/(array.GetLength(1)-1));
           array01[j]=Math.Round(count,1);                        
        }         
       Console.Write (array01[j] + " ");          
    }   
}
int [,] fillarray= Fillarray(3,4);
PrintArray(fillarray);
NewArray(fillarray);
*/






// задачи на семинаре
//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

/*int [,] FillArray ()// заполнение массива
{
Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input min possible value: ");
int minVal= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input max possible value: ");
int maxVal= Convert.ToInt32 (Console.ReadLine());

int [,] fill02Array = new int [rows, columns];

for (int i=0; i< rows; i++)
{
    for (int j=0;j< columns; j++)
    {
        fill02Array [i,j]= new Random().Next (minVal, maxVal+1);
    }
    
}
    return fill02Array;

}

void PrintArray (int [,] array) // вывод масcива
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
int [,] newArray = FillArray ();
PrintArray(newArray);
*/
/*Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
1 2 3 4      [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/
/*
int [,] FillArray()
{
 Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());

int [,] fillarray= new int [rows, columns];
for (int i=0; i< rows;i++)
{
    for (int j=0; j< columns; j++)
    {
        fillarray[i,j]=i+j;
    }
}
return fillarray;
}



void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
int[,] fillarray= FillArray();
PrintArray(fillarray);
*/
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

/*int [,] Fillarray (int row, int column, int minVal, int maxVal)
{
    int [,] fillarray = new int [row, column];
    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            fillarray [i,j]= new Random().Next (minVal, maxVal+1);
        }
    }
    return fillarray;
}

int [,] ChangedArray (int [,] array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            if (i % 2 !=1 && j % 2 !=1)
                array[i,j]*=array[i,j];//Math.Round ((Math.Pow(array[i,j]),2),2);
        }

    }
    return array;
}

 void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of colum: ");
int columns= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input min possible value: ");
int minsVal= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input max possible value: ");
int maxsVal= Convert.ToInt32 (Console.ReadLine());

int [,] fillarray=Fillarray(rows, columns,minsVal,maxsVal);
PrintArray(fillarray);
int [,] changedArray= ChangedArray(fillarray);
PrintArray(changedArray);
*/
