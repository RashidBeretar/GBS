// int a = 12345;
int a = 0;
int cnt = 0;
Console.WriteLine(a);
while (a > 0)
{
    a /= 10;
    Console.WriteLine(a);
    cnt++;
}
Console.WriteLine(cnt);

// пробую по-другому. Удалить
bool IsPalindrome(int number)
{
    while (0 == 1)
    {

    }



    if (!(10000 <= number && number <= 99999)) return false;
    if (!(number / 10000 == number % 10)) return false;
    number %= 10000;
    number /= 10;
    if (!(number / 100 == number % 10)) return false;
    return true;
}
// /пробую по-другому. Удалить