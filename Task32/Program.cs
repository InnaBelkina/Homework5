// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 100, 999);
ShowArray(myArray);

int amountPosNum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0) amountPosNum += 1;
}

Console.WriteLine($"Количество четных чисел в массиве = {amountPosNum}");