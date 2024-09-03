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
Console.Write("Введите длину в метрах: ");
double m = double.Parse(Console.ReadLine());

Console.WriteLine("Че те надо?\n1. мм\n2. см\n3. дм\n4. км");
int s = int.Parse(Console.ReadLine());

switch (s)
{
    case 1: Console.WriteLine($"{m * 1000d} мм"); break;
    case 2: Console.WriteLine($"{m * 100d} см"); break;
    case 3: Console.WriteLine($"{m * 10d} дм"); break;
    case 4: Console.WriteLine($"{m * 0.001d} км"); break;
}
Console.WriteLine(
