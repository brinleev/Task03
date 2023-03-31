// Напишите программу, которая будет выдавать название
// дня недели по заданному номеру.

Console.WriteLine("Введите число, которому соответствует день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
   Console.WriteLine("Понедельник первый день недели"); 
} 
else
if (number == 2)
{
   Console.WriteLine("Вторник второй день недели"); 
} 
else
if (number == 3)
{
   Console.WriteLine("Среда третий день недели"); 
} 
else
if (number == 4)
{
   Console.WriteLine("Четверг четвертый день недели"); 
} 
else
if (number == 5)
{
   Console.WriteLine("Пятница пятый день недели"); 
} 
else
if (number == 6)
{
   Console.WriteLine("Суббота шестой день недели"); 
} 
else
if (number == 7)
{
   Console.WriteLine("Воскресение седьмой день недели"); 
} 
else
if (number > 7)
{
   Console.WriteLine("Неделя состоит из семи дней недели"); 
}