// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrome(int number)
{
    if(!(10000 <= number && number <= 99999)) return false;
    if(!(number / 10000 == number % 10)) return false;
    number %= 10000;
    number /= 10;
    if(!(number / 100 == number % 10)) return false;
    return true;
}

Console.Write("Введите пятизначное число: " );
Console.WriteLine(IsPalindrome(int.Parse(Console.ReadLine())) ? "Является пятизначным полиндромом" : "Не является пятизначным полиндромом");