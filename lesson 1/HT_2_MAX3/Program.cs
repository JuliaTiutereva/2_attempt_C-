﻿Console.WriteLine("Введите три числа");
Console.Write("a = ");
string Num1 = Console.ReadLine();
int intNum1 = Convert.ToInt32(Num1);
Console.Write("b = ");
string Num2 = Console.ReadLine();
int intNum2 = Convert.ToInt32(Num2);
Console.Write("с = ");
string Num3 = Console.ReadLine();
int intNum3 = Convert.ToInt32(Num3);
int max = intNum1;
if (intNum2 > max) max = intNum2;
if (intNum3 > max) max = intNum3;
Console.Write("max = ");
Console.Write(max);