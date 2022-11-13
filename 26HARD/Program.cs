// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе. 
//452 -> 3 
//82 -> 2
//9,012 ->4

decimal GetNum(decimal n) {
    
    while (n != Math.Round(n, 0)) {
        n = n * 10;
    }
    n = Math.Round(n, 0);
    return n;
}

Console.WriteLine("Вычисление количества цифр в числе. Введите число");
decimal number = decimal.Parse(Console.ReadLine()!);
decimal result1 = GetNum(number);
int res = Convert.ToInt32(result1);
Console.WriteLine("Цифра без запятых: " + res);

int Sum(int res) {
    int summ = 0;

    if (res == 0) {
        summ = 1;
    }
    else {
    while (res > 0) {
        summ = summ + 1;
        res = res / 10;
    }
    }
    return summ;
}

int summ = Sum(res);
Console.WriteLine("Количество цифр: " + summ);