// Задача №17. Напишите программу, которая принимает на вход координаты точки (Х и Y),
// причем X не равен нулю и Y не равен нулю и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindQandrat(int x, int y)
{
    if ((x > 0) && (y > 0)) Console.WriteLine("Это первый квадрат");
    if ((x < 0) && (y > 0)) Console.WriteLine("Это второй квадрат");
    if ((x < 0) && (y < 0)) Console.WriteLine("Это третий квадрат");
    if ((x > 0) && (y < 0)) Console.WriteLine("Это четвёртый квадрат");
}

int x = DataEntryXY("Введите координаты x = ");
// Console.WriteLine(x);
int y = DataEntryXY("Введите координаты y = ");
// Console.WriteLine(y);
FindQandrat(x, y);