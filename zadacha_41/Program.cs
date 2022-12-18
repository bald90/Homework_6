// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();


int DataEntry(string str)                   // 1.1. Метод ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number1 = DataEntry("Введите число 1: ");    // 1.0 Запросить число
int number2 = DataEntry("Введите число 2: ");    // 1.0 Запросить число
int number3 = DataEntry("Введите число 3: ");    // 1.0 Запросить число
int number4 = DataEntry("Введите число 4: ");    // 1.0 Запросить число
int number5 = DataEntry("Введите число 5: ");    // 1.0 Запросить число


int count = 0;
if (number1 > 0) count = 1;
if (number2 > 0) count++;
if (number3 > 0) count++;
if (number4 > 0) count++;
if (number5 > 0) count++;

Console.WriteLine("-> " + count);        // Вывести колличество

