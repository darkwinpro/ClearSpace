using System;

public class Program
{
    public static void Main()
    {
        int h = Convert.ToInt32(Console.ReadLine());
        int w = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[ h , w];
        int[,] arrayOfCoords = new int[n, 4];
        int sum = 0;        //количество не закрашенных элементов
        
        //считываем координаты прямиугольников в массив
        for (var i = 0; i < arrayOfCoords.GetLength(0); i++)
        {
            for (var j = 0; j < arrayOfCoords.GetLength(1); j++)
            {
                arrayOfCoords[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            // заполняем площади прямоугольков значениями "1"
            for (int x = arrayOfCoords[i, 0]; x < arrayOfCoords[i, 2]; x++)
            {
                for (int y = arrayOfCoords[i, 1]; y < arrayOfCoords[i, 3]; y++)
                {
                    array[y, x] = 1;
                }   
            }
        }
            // подсчет элементов , которые заполнены "0" 
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == 0)
                {
                    sum++;
                }
                //Console.Write( array[i,j] + " ");
            }
            //Console.WriteLine();
        }
        Console.WriteLine(sum);
    }
}