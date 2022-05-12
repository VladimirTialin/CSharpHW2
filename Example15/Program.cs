/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите число от 1 до 7: ");
sbyte Number = Convert.ToSByte(Console.ReadLine());
if (Number == 6 || Number == 7)
{
    Console.WriteLine($" Введенное число {Number} является выходным днем!");
}
else if (Number > 0 && Number < 6) 
{
    Console.WriteLine($" Введенное число {Number} является рабочим днем!");
}
else
{
   Console.WriteLine("Ошибка ввода! В неделе всего 7 дней!"); 
}