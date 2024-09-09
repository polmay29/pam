//задание 1
//Console.WriteLine("Введите первое число");
//double a =Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите второе число");
//double b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите действие деление (/) ,умножение (*),сложение (+),вычитание (-)");
//string c = Console.ReadLine();
//double d = 0;

//if (c == "+")
//{
//    d = a + b;
//    Console.WriteLine(d);


//}
//if (c == "/")
//{
//    d = a / b;
//    Console.WriteLine(d);

//}
//if (c == "*")
//{   d = a * b;
//    Console.WriteLine(d);

//}
//if (c == "-")
//{   d = a - b;  
//    Console.WriteLine(d);

//}
/////////////////////////////
//задание 2 
//Console.WriteLine("ВВЕДИТЕ СТРОКУ");
//string a = Convert.ToString(Console.ReadLine());
//int b = a.Length;
//string[] c = a.Split(',');
//Console.WriteLine("количество символов " + b);
//string[] s = a.Split("");
//int q = s.Length;
//Console.WriteLine("количество слов " + q);
//string[] x = a.Split('.','!','?');
//int y = x.Length-1;   
//Console.WriteLine("количество предложений " + y);
///////////////////////////
//ЗАДАНИЕ 3 
//Console.WriteLine("умножение");
//int a = 10;
//for (int i = 1; i <= a; i++)
//{
//    for (int j = 0; j < a; j++)
//    {
//        Console.Write($"{i} * {j} = {i*j}\t");
//    }
//    Console.WriteLine();
//}
//////////////////
//задание 4 
//Console.WriteLine("введите число ");
//int n =Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"факториарное число{n} = {f(n)}");
//static int f (int x) 
//{
//    if (x == 0)
//        return 1;
//    else return x * f (x - 1);

//}
//////////////////////////
///задание 5
///
//Console.WriteLine("введите кроличество чисел ");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 0;
//int b = 1;
//for(int i = 0; i<n; i++) 
//{
//    Console.Write(a + "");
//    int x = a;
//    a = b;
//    b = x + b;
//}
///////////////задание 6

//Console.Write("Введите число n");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"простые числа от 1 до {n}");
//for (int i = 2; i <= n; i++) 
//{ 
//    bool c = true;
//    for (int j = 2; j <= Math.Sqrt(i); j++) 
//    {
//        if (i % j == 0) 
//        { 
//            c = false; 
//            break;
//        }
//    }
//    if (c) 
//    { 
//        Console.WriteLine(i);
//    }
//}
///////////////////////////
//задание 7
/////////////////////
//   Random random = new Random();
//int t = random.Next(1, 101);
//int u = 0;
//int a = 0;
//Console.WriteLine("угадайте числа от 1 до 100");
//while (u != t) 
//{
//    Console.WriteLine("введите число :");
//    string i = Console.ReadLine();
//    if (int.TryParse(i, out u)) 
//    {
//        a++;
//        if (u != t)
//        {
//            Console.WriteLine(u < t ? "число больше" : "загаданное число меньше");

//        }
//        else 
//        {
//            Console.WriteLine("вы угадали число {t} с  {a}попытки");
//        }

//    }
//}
///////////////////////////8 задание
//Console.WriteLine("введите фигуру");
//string a = Console.ReadLine();
//if (a ! == "круг") 
//{
//    Console.WriteLine("введите число :");
//    int r =Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("площадь прямоугольника равна :" + (3.14 * (r * r)));
//}
//if(a == "треугольник") 
//{ 
//    Console.WriteLine(" Введите число ");
//    int c = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("ВВЕДИТЕ ЧИСЛО :");
//    int t = Convert.ToInt32(Console.ReadLine()); 
//   Console.WriteLine("ВВЕДИТЕ ЧИСЛО :");
//    int h = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("площадь треугольника равна :" + ((c+t+h/2)));
//}
//if (a == "прямоугольник") 
//{
//    Console.WriteLine(" Введите число ");
//    int l = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("ВВЕДИТЕ ЧИСЛО :");
//    int p = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("площадь прямоугольника равна :" + ((l * p)));


//}
////////////задание 9
Console.WriteLine("Выберите единицу измерения: \n1. Длинна\n2. Вес");
double s = double.Parse(Console.ReadLine());

if (s == 1)
{
    Console.Write("Введите длину в метрах: ");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мм\n2. см\n3. дм\n4. км");
    int l = int.Parse(Console.ReadLine());

    switch (l)
    {
        case 1: Console.WriteLine($"{m * 1000} мм"); break;
        case 2: Console.WriteLine($"{m * 100} см"); break;
        case 3: Console.WriteLine($"{m * 10} дм"); break;
        case 4: Console.WriteLine($"{m * 0.001} км"); break;
    }
}
else
{
    Console.Write("Введите вес в киллограммах: ");
    double e = double.Parse(Console.ReadLine());
    Console.WriteLine("Выбор: \n1. мг\n2. гр\n3. тонны\n4. пуды");
    int p = int.Parse(Console.ReadLine());

    switch (p)
    {
        case 1: Console.WriteLine($"{e * 1000000} мг"); break;
        case 2: Console.WriteLine($"{e * 1000} гр"); break;
        case 3: Console.WriteLine($"{e * 0,001} тонны"); break;
        case 4: Console.WriteLine($"{e * 0.06105} пуды"); break;
    }
}
/////////задание 10
//Console.WriteLine("введите число :");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Напишите процент");
//double g = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"{g} от  {z} {(z/100) * g}");

///////// 11
//Console.WriteLine("Введите число: ");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("выберите формулу: \n 1)рубли в тенге \n 2) тенге в рубли");
//int a = Convert.ToInt32(Console.ReadLine());
//if(a == 1) 
//{
//    Console.WriteLine(x * 5.45);
//}
// else if (a == 2) 
//{
//    Console.WriteLine(x / 5.45);
//}
////////// 12 задание
//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}

//int min = a.Min();
//int indexMin = Array.IndexOf(a, min);
//Console.WriteLine("Минимальное:" + min);
//Console.WriteLine("Индекс минимального:" + indexMin);


//int max = a.Max();
//int indexMax = Array.IndexOf(a, max);
//Console.WriteLine("Максимальное:" + max);
//Console.WriteLine("Индекс максимального:" + indexMax);

//////////////13
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//}

//Console.WriteLine("Исходный массив:");
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (пузырьком):");
//BubbleSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (пузырьком):");
//BubbleSort(a, false);
//PrintArray(a);

//Console.WriteLine("\nСортировка по возрастанию (вставками):");
//InsertionSort(a, true);
//PrintArray(a);

//Console.WriteLine("\nСортировка по убыванию (вставками):");
//InsertionSort(a, false);
//PrintArray(a);


//// Метод для сортировки пузырьком
//static void BubbleSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if ((g && a[j] > a[j + 1])(!g && a[j] < a[j + 1]))
//            {
//                int t = a[j];
//                a[j] = a[j + 1];
//                a[j + 1] = t;
//            }
//        }
//    }
//}

//// Метод для сортировки вставками
//static void InsertionSort(int[] a, bool g)
//{
//    int n = a.Length;
//    for (int i = 1; i < n; i++)
//    {
//        int k = a[i];
//        int j = i - 1;

//        while (j >= 0 && ((g && a[i] > k)(!g && a[j] < k)))
//        {
//            a[j + 1] = a[j];
//            j = j - 1;
//        }
//        a[j + 1] = k;
//    }
//}

//// Метод для вывода массива
//static void PrintArray(int[] a)
//{
//    Console.WriteLine(string.Join(", ", a));
//}

////////////////////14
//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Введите элемент для поиска:");
//int m = int.Parse(Console.ReadLine());

//int index = Array.IndexOf(a, m);

//if (index >= 0)
//{
//    Console.WriteLine($"Число {m} найдено на индексе {index}.");

//}
//else
//{
//    Console.WriteLine("Число не найдено.");
//}

////////////////////////////15 задания
//Console.WriteLine("Рандомные числа:");
//int[] a = new int[10];

//Random random = new Random();
//for (int i = 0; i < 10; i++)
//{
//    a[i] = random.Next(1, 100);
//    Console.WriteLine($"Число {i + 1}: {a[i]}"); // Выводим каждое сгенерированное число
//}
//Console.WriteLine("Массив в обратном порядке:");

//// Вывод элементов массива в обратном порядке
//for (int i = a.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(a[i]);
//}

///////////////////\ 16 задание
//int[,] A = { { 1, 2 }, { 3, 4 } }; int[,] B = { { 5, 6 }, { 7, 8 } };
//// Сложение
//Console.WriteLine("Сложение:"); PrintMatrix(Add(A, B));
//// Вычитание
//Console.WriteLine("\nВычитание:"); PrintMatrix(Subtract(A, B));
//// Умножение
//Console.WriteLine("\nУмножение:"); PrintMatrix(Multiply(A, B));
//// Транспонирование
//Console.WriteLine("\nТранспонирование A:"); PrintMatrix(Transpose(A));
//Console.WriteLine("\nТранспонирование B:"); PrintMatrix(Transposeу(B));

//static int[,] Add(int[,] A, int[,] B) => new int[,]
//    {             { A[0, 0] + B[0, 0], A[0, 1] + B[0, 1] },
//        { A[1, 0] + B[1, 0], A[1, 1] + B[1, 1] }         };
//static int[,] Subtract(int[,] A, int[,] B) =>
//    new int[,]         {
//        { A[0, 0] - B[0, 0], A[0, 1] - B[0, 1] },             { A[1, 0] - B[1, 0], A[1, 1] - B[1, 1] }
//    };
//static int[,] Multiply(int[,] A, int[,] B) => new int[,]
//    {             { A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0], A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] },
//        { A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0], A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] }         };
//static int[,] Transpose(int[,] A) =>
//    new int[,]         {
//        { A[0, 0], A[1, 0] },             { A[0, 1], A[1, 1] }
//    };
//static int[,] Transposeу(int[,] B) =>
//    new int[,]         {
//        { B[0, 0], B[1, 0] },             { B[0, 1], B[1, 1] }
//    };
//static void PrintMatrix(int[,] matrix)
//{
//    Console.WriteLine($"{matrix[0, 0]} {matrix[0, 1]}"); Console.WriteLine($"{matrix[1, 0]} {matrix[1, 1]}");
//}

Полина, [09.09.2024 20:03]
//17 задание


//Console.WriteLine("Введите число в десятичной системе:");
//int n = int.Parse(Console.ReadLine());

//// Перевод в другие системы счисления
//string b = Convert.ToString(n, 2);
//string o = Convert.ToString(n, 8);
//string l = Convert.ToString(n, 16);

//Console.WriteLine($"Двоичная: {b}");
//Console.WriteLine($"Восьмеричная: {o}");
//Console.WriteLine($"Шестнадцатеричная: {l.ToUpper()}");


// 18 задание

//Console.WriteLine("Введите количество уровней пирамиды: ");
//int s = int.Parse(Console.ReadLine());
//Console.WriteLine("Пирамида:");

//for (int i = 1; i <= s; i++)
//{
//    Печатаем пробелы перед числами
//    for (int j = 1; j <= s - i; j++)
//    {
//        Console.Write(" ");
//    }

//    Печатаем числа
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write(k);
//    }

//    Печатаем числа в обратном порядке
//    for (int l = i - 1; l >= 1; l--)
//    {
//        Console.Write(l);
//    }

//    Console.WriteLine();
//}

//19 Задание

//// Ввод строки
//Console.WriteLine("Введите строку: ");
//string g = Console.ReadLine();

//// Ввод подстроки
//Console.WriteLine("Введите подстроку для поиска: ");
//string n = Console.ReadLine();

//// Поиск индекса подстроки
//int index = g.IndexOf(n);

//// Проверка и вывод результата
//if (index != -1)
//{
//    Console.WriteLine($"Подстрока найдена на позиции: {index}");
//}
//else
//{
//    Console.WriteLine("Подстрока не найдена.");
//}


//20 задание


//Console.WriteLine("Введите строку с лишними пробелами: ");
//string inputString = Console.ReadLine();

//// Разделение строки по пробелам, удаление пустых частей и объединение с одним пробелом
//string resultString = string.Join(" ", inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

//// Вывод результата
//Console.WriteLine($"Строка после удаления лишних пробелов: \n'{resultString}'");


// 21 Задание

//Console.WriteLine("Введите первую дату (ГГГГ-ММ-ДД): ");
//DateTime date1 = DateTime.Parse(Console.ReadLine());

//// Ввод второй даты
//Console.WriteLine("Введите вторую дату (ГГГГ-ММ-ДД): ");
//DateTime date2 = DateTime.Parse(Console.ReadLine());

//// Вычисление разницы в днях
//int daysDifference = Math.Abs((date2 - date1).Days);

//// Вывод результата
//Console.WriteLine($"Количество дней между датами: {daysDifference}");


// 22 Задание
//using System.Text.RegularExpressions;

//Console.WriteLine("Введите номер телефона (например, +7 (123) 456-78-90):");
//string phoneNumber = Console.ReadLine();
//if (IsValidRussianPhoneNumber(phoneNumber))
//{
//    Console.WriteLine("Номер телефона введен корректно.");
//}
//else
//{
//    Console.WriteLine("Номер телефона введен некорректно.");
//}

//Console.WriteLine("Введите e-mail (например, example@example.com):");
//string email = Console.ReadLine();
//if (IsValidEmail(email))
//{
//    Console.WriteLine("E-mail введен корректно.");
//}
//else
//{
//    Console.WriteLine("E-mail введен некорректно.");
//}


//    static bool IsValidRussianPhoneNumber(string phoneNumber)
//{
//    // Регулярное выражение для проверки российского номера телефона
//    string pattern = @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$";
//    return Regex.IsMatch(phoneNumber, pattern);
//}

//static bool IsValidEmail(string email)
//{
//    // Регулярное выражение для проверки e-mail
//    string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//    return Regex.IsMatch(email, pattern);
//}

// 23 Задание

//using System.Text;

//        Console.WriteLine("Введите длину пароля:");
//        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
//        {
//            string password = GenerateRandomPassword(length);
//            Console.WriteLine($"Сгенерированный пароль: {password}");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: введите положительное целое число.");
//        }


//    static string GenerateRandomPassword(int length)
//    {
//        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?/[]{}|";

Полина, [09.09.2024 20:03]
//        string allChars = upperCase;
//        StringBuilder password = new StringBuilder(length);
//        Random random = new Random();

//        for (int i = 0; i < length; i++)
//        {
//            char randomChar = allChars[random.Next(allChars.Length)];
//            password.Append(randomChar);
//        }

//        return password.ToString();
//    }


// 24 Задание

//decimal totalAmount = 0m;
//string input;
//const decimal vatRate = 0.20m; // НДС 20%

//Console.WriteLine("Введите список покупок и их стоимость. Введите 'done', чтобы завершить ввод.");

//while (true)
//{
//    Console.Write("Введите название товара (или 'done' для завершения): ");
//    input = Console.ReadLine();
//    if (input.ToLower() == "done") break;

//    Console.Write("Введите стоимость товара (или 'done' для завершения): ");
//    input = Console.ReadLine();
//    if (input.ToLower() == "done") break;

//    if (decimal.TryParse(input, out decimal itemPrice) && itemPrice >= 0)
//    {
//        totalAmount += itemPrice;
//    }
//    else
//    {
//        Console.WriteLine("Некорректная стоимость. Попробуйте снова.");
//    }
//}

//decimal vatAmount = totalAmount * vatRate;
//decimal totalWithVat = totalAmount + vatAmount;

//Console.WriteLine("\n--- Чек ---");

//Console.WriteLine($"Итоговая сумма: {totalAmount:C}");
//Console.WriteLine($"НДС (20%): {vatAmount:C}");
//Console.WriteLine($"Итог с НДС: {totalWithVat:C}");


// 25 Задание 

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        // Ввод текста
//        Console.WriteLine("Введите текст:");
//        string input = Console.ReadLine();

//        // Разбиение текста на слова и подсчет частоты
//        var wordCount = input.ToLower()
//                             .Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
//                             .GroupBy(word => word)
//                             .ToDictionary(group => group.Key, group => group.Count());

//        // Вывод результата
//        Console.WriteLine("\nЧастота слов:");
//        foreach (var word in wordCount)
//        {
//            Console.WriteLine($"{word.Key}: {word.Value}");
//        }
//    }
//}
