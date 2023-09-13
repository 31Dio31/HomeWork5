/* Задачи находятся в ветках:
Задача 54 - ветка main;
Задача 56 - ветка vetka2;
Задача 58 - ветка vetka3;
Задача 60  - не смог решить
Задача 62 - ветка vetka5;
*/

/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/



var array = GetArray(5,5); // запуск генерации массива 5х5
PrintArray(array); // вывод на экран полученного массива
Console.WriteLine(); // пробел (отсутп) после массива
Sorting(array); // запуск метода сортировки массива
PrintArray(array); // вывод на экран отсортированного массива


void Sorting (int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			for (int k = 0; k < array.GetLength(1)-1; k++)
			{
			if (array [i, k] < array[i, k+1])
			{
			 int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
		}	
}
}
}
}


void PrintArray(int[,] array) // функция печати массива из 3 строк 4 столбцов
{
for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
		Console.Write(array[i, j] + " ");
	}
	Console.WriteLine();
}
}

int[,] GetArray(int rows, int cols) // функция генерации массива из случайных чисел
{
	Random random = new Random();
	int [,] array = new int[rows, cols]; 
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(1, 50); 
		}
	}
	return array;
}
