/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int Number = Convert.ToInt16(Console.ReadLine());
int Result;
if (Number > 99 && Number < 999)
{
    Result = (Number % 10);
    Console.WriteLine(Number+" - > "+Result);
}
else if (Number > 999 && Number < 9999)
{
    Result = ((Number % 100)/10);
    Console.WriteLine(Number+" - > "+Result);
}
else if (Number > 9999)
{
    Result = ((Number % 1000)/100);
    Console.WriteLine(Number+" - > "+Result);
}
else
{
    Console.WriteLine(Number+" - >  третьей цифры нет");
}
