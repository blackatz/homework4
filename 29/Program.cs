// напишите программу, которая задает массив из 8 элементов и выводит их на экран
Console.WriteLine("Введите числа массива ");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = int.Parse(Console.ReadLine()!);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

int [] array = new int [8];

FillArray(array);
Console.WriteLine("Ваш массив ");
PrintArray(array);
