// напишите программу, которая принимает на вход число и выдает сумму цифр в числе

int GetSumNum(int n) {
    int result = 0;

    if (n == 0) {
        result = 1;
    }
    else {
    while (n > 0) {
        result = result + n%10;
        n = n / 10;
    }
    }
    
    return result;
}


Console.WriteLine("Вычисление суммы цифр в числе");
int number = int.Parse(Console.ReadLine()!);
int result = GetSumNum(number);
Console.WriteLine("Результат: " + result);