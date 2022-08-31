Console.WriteLine("Введите два числа.");
Console.Write("Первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine(num1 + " большее");
    Console.Write(num2 + " меньшее");
}
else if (num1 == num2)
{
    Console.WriteLine(num1 + " равно " + num2);
}
else
{
    Console.WriteLine(num2 + " большее");
    Console.Write(num1 + " меньшее");
}