//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

void getArray(int[] array, int size, int start, int end)
{
    Random rng = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rng.Next(start, end + 1); //+1 для того чтобы число end было включено в диапозон рнг чисел
    }
}

void printArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] massiv = new int[8];
getArray(massiv, 8, 77, 777);
printArray(massiv);
