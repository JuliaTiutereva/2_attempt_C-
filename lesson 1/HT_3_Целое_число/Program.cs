Console.WriteLine("Введите числo");
string Num = Console.ReadLine();
double D_Num = Convert.ToDouble(Num);
double quotient = D_Num % 2;
if (quotient == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.Write("нет");
}
