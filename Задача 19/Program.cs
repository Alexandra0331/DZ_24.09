// 19.Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//int n = int(input("Введите число:"));
int temp = n;
int rev = 0;
int count = 0;
while(n > 0)
{
    count = n % 10;
    rev = rev * 10 + count;
    n = n / 10;
}
if(temp == rev)
{
Console.Write("Это палиндром!");
}
else
{
Console.Write("Это не палиндром!");
};