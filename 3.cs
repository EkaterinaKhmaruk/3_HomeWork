//Напишите программу, которая на вход принимает число и выдаёт, является 
//ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = a % 2;
if (result == 0)
{
    Console.WriteLine("Число чётное");
}
else 
{
    Console.WriteLine("Число нечётное");
}