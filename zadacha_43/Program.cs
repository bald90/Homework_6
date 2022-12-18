// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();


double DataEntry(string str)                   // 1.1. Метод ввода данных
{
    Console.WriteLine(str);
    double number = double.Parse(Console.ReadLine());

    return number;
}

double b1 = DataEntry("Введите b1: ");    // 1.0 Запросить число
double k1 = DataEntry("Введите k1: ");    // 1.0 Запросить число
double b2 = DataEntry("Введите b2: ");    // 1.0 Запросить число
double k2 = DataEntry("Введите k2: ");    // 1.0 Запросить число

double x = (b2-b1)/(k1-k2);
double y = k1 * x + b1;

System.Console.WriteLine($"Пересечениев точке: ({x} ; {y})");