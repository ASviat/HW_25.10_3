// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введи число, дабы прильнуть, палиндром ли: ");
int num = Convert.ToInt32(Console.ReadLine());

int QuantInt(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int quantity = QuantInt(num);


int[] arr = new int[quantity];
int krat = 1;
int rightSide = quantity;
arr[0] = num % 10;
for (int i = 1; i < quantity; i++)
{
    arr[i] = (num / (10 * krat)) % 10;
    krat *= 10;
}

int simetry = quantity / 2;
int steps = default;
int count = 1;

while (arr[quantity - rightSide] == arr[quantity - count] && count - 1 != simetry)
{
    rightSide--;
    count++;
    steps++;
}

if (steps < simetry) Console.WriteLine("Не палиндром");
else Console.WriteLine("Таки палиндром!!!");