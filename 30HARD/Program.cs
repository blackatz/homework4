// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.. 
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей 
// то вывести TRUE на экран, иначе вывести False.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        collection[index] = random.Next(0,2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int SumOf(int[] collection, int sum0, int sum1)
{
    int count = collection.Length;
    int index = 0;
    int sumof0 = 0;
    int sumof1 = 0;

    while (index < count)
    {
        if(collection[index] == sum0)
        {
            sumof0 = sumof0 + 1;
        }

        else {
            sumof1 = sumof1 + 1;
        }

        index++;        
    }

    if (sumof0 > sumof1) {
        Console.WriteLine("FALSE");
    }

    else {
        Console.WriteLine("TRUE");
    }

    return index;
}

int [] array = new int [8];

FillArray(array);
PrintArray(array);
SumOf(array, 0, 1);