/*Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

Console.Write("Введите числа: ");
string? number = Console.ReadLine();
int count = 0;

string[] numbers = number!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
   foreach (string s in numbers)
   {
    char ch = '-';
    int indexOfChar = s.IndexOf(ch);
    if (indexOfChar == -1 && s != "0") count++;
    
    }

Console.WriteLine($"Количество чисел больше 0: {count}");