// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/* Данные для проверки:
456 -> 5
782 -> 8
918 -> 1
*/
// Решение задачи 10:
/*
int SecondNum(int num_1)
{   
    int num2 = num_1 / 10;
    int res = num2 % 10; 
    return res;    
}

Console.WriteLine("Введите трёхзначное число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вторая цифра, в заданном Вами числе: {num_1}, это цифра: {SecondNum(num_1)}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* Данные для проверки:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
// Решение задачи 13 (не знаю можно ли так решать, но другого решения за два дня не нашёл, классно было бы разобрать эту задачу на семинаре, в чате у многих были по ней вопросы. Спасибо.):
/*
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
string [] numberArray = new string[num.Length];
int counter = 0;

   for (int i = 0; i < num.Length; i++)
   {
     numberArray[i] = num.Substring(counter, 1);
     counter++;
   }
try
{
    Console.WriteLine(numberArray[2]);
}
catch
{
    Console.WriteLine("Извини бро 3-его значения в твоем числе нет :(");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Решение задачи 15:
/*
void Week (int num)
{
    int[] days = {1, 2, 3, 4, 5, 6, 7};
    if(days[5] == num || days[6] == num)
    {
        Console.WriteLine("Это выходной день! Ю-хХх-у! :)");
    }
    else
    {
        Console.WriteLine("Это будний день и до выходных еще пахать и пахать! :(");
    }

}

Console.WriteLine("Введите число (1-7) обозначающее день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
Week(num);
*/