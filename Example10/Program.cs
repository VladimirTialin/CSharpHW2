/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// Задачка слишком легкая, решил немного добавить конкретики!!!
Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 99 && Number < 999)
{
    int Result = (Number % 100);
    Result = (Result/10);
    Console.WriteLine(Number+" - > "+Result);
}
else
{
  Console.WriteLine("Ошибка ввода! Введено не трехзначное число. Попробуйте еще раз :-)");  
}