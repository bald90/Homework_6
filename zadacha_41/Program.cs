// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

///Цель:
///1. ввести размер массива
///2. заполнить его рандомными числами
///3. определить больше 0
///4. вывести на экран

Console.Clear();

//Вариант № 1
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);  // подсмотрел решение в сети.      
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("-> " + count);


// Вариант № 2. Предположил что пользователь может ввести потенциальный размер массива...

// int DataEntry(string str)                       // Метод ввода данных
// {
//     Console.WriteLine(str);
//     int SIZE = int.Parse(Console.ReadLine());
//     return SIZE;
// }

// int SIZE = DataEntry("введите число = ");     // просим ввести число (потенциально разер массива)

// const int LEFT_RANGE = -9;
// const int RIGHT_RANGE = 9;
// int[] array = new int[SIZE];  //создали массив

// int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
// {
//     Random rand = new Random();             //создали объект класса рандом
//     int[] arr = new int[size];              // объявили массив
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(leftRange, rightRange + 1);
//         // arr[0] = 1;
//         // arr[1] = -7;
//         // arr[2] = 567;
//         // arr[3] = 89;
//         // arr[4] = 223;
//     }
//     return arr;
// }
// array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
// System.Console.WriteLine('[' + string.Join(", ", array) + ']');

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         count += 1;
//     }
// }
// System.Console.WriteLine("-> " + count);



//Вариант № 3 из сети...
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);   
// int count = arr.Count(x => x > 0);                                   //не понял что такое "х" , чем оно определяется и что означает запись x => x>0
// Console.WriteLine($"Кол-во элементов > 0: {count}");








