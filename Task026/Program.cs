//Напишите программу, которая принимает
//на вход число N и выдаёт количество цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {a(s)}");


int a(int number)
{
int count = 0;
while(number>0)
{
count++;
number/=10;
}
return count;
}