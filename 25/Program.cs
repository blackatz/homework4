// напишите цикл, который принимает на вход два числа (А и В) и возводит 
// число А в натуральную степень В

int Exp(int a, int b) {
    int exponen = a;
    int count = 1;

    if (a == 0) {
        exponen = 0;
    }

    else {
        while (count < b) {
            count++;
            exponen = exponen * a;
    }}

    return exponen;
}

Console.WriteLine("Программа для возведения А в степень В");
Console.WriteLine("Введите А: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите B: ");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Итог: " + Exp(a, b));