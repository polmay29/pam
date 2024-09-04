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

