//50 Пятьдесят задач по Паскалю



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void task1()
        {
            Console.WriteLine("Вывести на экран сообщение «Hello World!».");
            Console.WriteLine("Hello World!");
        }
        static void task2()
        {
            Console.WriteLine("Вывести на экран три введенных с клавиатуры числа в порядке, обратном их вводу.");
            string a, b, c;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine(c + " " + b + " " + a);
        }
        static void task3()
        {
            Console.WriteLine("Дано натуральное число меньше 256. Сформировать число, представляющее собой его квадрат.");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            a = a * a;
            Console.WriteLine(a);
        }
        static void task4()
        {
            Console.WriteLine("Сформировать число, представляющее собой реверсную (обратную в порядке следования разрядов) запись заданного трехзначного числа. Например, для числа 341 таким будет 143.");
            string a;
            a = Console.ReadLine();
            Console.Write(a[2]);
            Console.Write(a[1]);
            Console.WriteLine(a[0]);
        }
        static void task5()
        {
            Console.WriteLine("Дано натуральное число меньше 16. Посчитать количество его единичных битов. Например, если дано число 9, запись которого в двоичной системе счисления равна 10012 (подстрочная цифра 2 справа от числа означает, что оно записано в двоичной системе счисления), то количество его единичных битов равно 2.");
            int n, count;
            n = Convert.ToInt32(Console.ReadLine());
            count = 0;
            count = count + n % 2;
            n = n / 2;
            count = count + n % 2;
            n = n / 2;
            count = count + n % 2;
            n = n / 2;
            count = count + n;
            Console.WriteLine(count);
        }
        static void task6()
        {
            Console.WriteLine("Даны два числа. Вывести на экран то из них, которое больше.");
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            if (n > m) Console.WriteLine(n);
            else Console.WriteLine(m);
        }
        static void task7()
        {
            Console.WriteLine("Даны три числа. Вывести на экран то из них, которое больше.");
            int n, m, s;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            if ((n > m) && (n > s)) Console.WriteLine(n);
            if ((s > m) && (s > n)) Console.WriteLine(s);
            if ((m > n) && (m > s)) Console.WriteLine(n);
        }
        static void task8()
        {
            Console.WriteLine("Дано число от 1 до 7. Вывести название дня недели по его номеру.");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("This day of the week does not exist!");
                    break;
            }
        }
        static void task9()
        {
            Console.WriteLine("Дано четырехзначное число. Проверить, является ли оно палиндромом. Примечание: палиндромом называется число, слово или текст, которые одинакового читаются слева направо и справа налево. Например, в нашем случае это числа 1441, 5555, 7117 и т. д");
            string s = Console.ReadLine();
            if ((s[0] == s[3]) && (s[1] == s[2])) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        static void task10()
        {
            Console.WriteLine("Дано четырехзначное число. Проверить, является ли оно «счастливым билетом». Примечание: счастливым билетом называется число, в котором: а) при четном количестве цифр в числе сумма цифр его левой половины равна сумме цифр его правой половины; б) при нечетном количестве цифр – то же самое, но с отбрасыванием серединной цифры. Например, рассмотрим число 1322. Его левая половина равна 13, а правая – 22, и оно является счастливым билетом (т. к. 1 + 3 = 2 + 2). Аналогично: 1735 (1 + 7 = 3 + 5), 1111 (1 + 1 = 1 + 1) и т. д.");
            int n, left, right;
            n = Convert.ToInt32(Console.ReadLine());
            right = n % 10;
            n = n / 10;
            right = right + n % 10;
            n = n / 10;
            left = n % 10;
            n = n / 10;
            left = left + n;
            Console.WriteLine(left == right);
        }
        static void task11()
        {
            Console.WriteLine("Дано число типа byte. Проверить, является ли палиндромом его двоичное представление с учетом того, что сохранены старшие нули. Пример таких чисел: 102 (т. к. 102 = 0110 01102, а это палиндром), 129 (129 = 1000 00012) и т. ");
            int n, a, b, c, d;
            n = Convert.ToInt32(Console.ReadLine());
            a = n % 2;
            n = n / 2;
            b = n % 2;
            n = n / 2;
            c = n % 2;
            n = n / 2;
            d = n % 2;
            n = n / 2;
            a = 8 * a + 4 * b + 2 * c + d;
            Console.WriteLine(n == a);
        }
        static void task12()
        {
            Console.WriteLine("Даны вещественные числа a, b и c, причем a отлично от 0. Решить квадратное уравнение ax2 + bx + c = 0 или сообщить о том, что действительных решений нет.");
            double a, b, c, d;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d == 0) Console.WriteLine(-(b / 2 * a));
            if (d < 0) Console.WriteLine("No real solutions!");
            if (d > 0)
            {
                Console.Write((-b + Math.Sqrt(d)) / 2 * a);
                Console.Write(" ");
                Console.WriteLine((-b - Math.Sqrt(d)) / 2 * a);
            }
        }
        static void task13()
        {
            Console.WriteLine("Дано натуральное число. Вывести на экран все натуральные числа до заданного включительно.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static int task14()
        {
            Console.WriteLine("Дано натуральное число. Найти его наибольший нетривиальный делитель или вывести единицу, если такового нет.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            for (i = (a / 2); i > 1; i--) if (a % i == 0)
                {
                    Console.WriteLine(i);
                    return 0;
                }
            Console.WriteLine('1');
            return 0;
        }
        static int task15()
        {
            Console.WriteLine("Дано натуральное число. Найти его наименьший нетривиальный делитель или вывести само это число, если такового нет.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < a; i++) if (a % i == 0)
                {
                    Console.WriteLine(i);
                    return 0;
                }
            Console.WriteLine(a);
            return 0;
        }
        static void task16()
        {
            Console.WriteLine("Дано натуральное число. Подсчитать общее количество его делителей.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (i = 1; i <= a; i++) if (a % i == 0) n++;
            Console.WriteLine(n);
        }
        static void task17()
        {
            Console.WriteLine("Дано натуральное число. Проверить, является ли оно простым. Примечание: простым называется натуральное число, которое имеет ровно два различных натуральных делителя: единицу и само это число.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (i = 1; i <= a; i++) if (a % i == 0) n++;
            Console.WriteLine(n <= 2);
        }
        static void task18()
        {
            Console.WriteLine("Дано натуральное число. Вывести на экран все простые числа до заданного включительно.");
            int a, i, j;
            a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (i = 1; i <= a; i++)
            {
                n = 0;
                for (j = 1; j <= i; j++)
                    if (i % j == 0) n++;
                if (n <= 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        static void task19()
        {
            Console.WriteLine("Дано натуральное число n. Вывести на экран n первых простых чисел. Например, при вводе числа 10 программа должна вывести ответ: 2 3 5 7 11 13 17 19 23 29");
            int a, i, j, m;
            a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            m = 0;
            for (i = 1; m < a; i++)
            {
                n = 0;
                for (j = 1; j <= i; j++)
                    if (i % j == 0) n++;
                if (n <= 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    m++;
                }
            }
            Console.WriteLine();
        }
        static void task20()
        {
            Console.WriteLine("Дано натуральное число. Проверить, является ли оно совершенным. Совершенным числом называется натуральное число, равное сумме всех своих собственных делителей (то есть натуральных делителей, отличных от самого числа). Например, 6 – совершенное число, оно имеет три собственных делителя: 1, 2, 3, и их сумма равна 1 + 2 + 3 = 6.");
            int a, i;
            a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (i = 1; i < a; i++) if (a % i == 0) n += i;
            Console.WriteLine(n == a);
        }
        static void task21()
        {
            Console.WriteLine("Даны два натуральных числа. Проверить, являются ли они дружественными. Дружественными числами называются два различных натуральных числа, для которых сумма всех собственных делителей первого числа равна второму числу и сумма всех собственных делителей второго числа равна первому числу.");
            int a, i, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            for (i = 1; i < a; i++) if (a % i == 0) n += i;
            int m = 0;
            for (i = 1; i < b; i++) if (b % i == 0) m += i;
            Console.WriteLine((n == b) && (m == a));
        }
        static void task22()
        {
            Console.WriteLine("Даны два натуральных числа. Найти их наибольший общий делитель.");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            while (!(a == b))
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine(a);
        }
        static void task23()
        {
            Console.WriteLine("Даны два натуральных числа. Найти их наименьшее общее кратное.");
            int a, b, i;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            i = a * b;
            while (!(a == b))
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine(i / a);
        }
        static void task24()
        {
            Console.WriteLine("Даны натуральные числа x и n (которое также может быть равно 0). Вычислить x в степени n.");
            int a, b, i, s;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a;
            if (a == 0) Console.WriteLine("1");
            else for (i = 1; i < b; i++) s *= a;
            Console.WriteLine(s);
        }
        static void task25()
        {
            Console.WriteLine("Даны натуральные числа x и n. Вычислить x в степени n, используя алгоритм быстрого возведения в степень.");
            int x, n, r;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            r = 1;
            while (n != 1)
            {
                if (n % 2 == 1) r = r * x;
                x = x * x;
                n = n / 2;
            }
            Console.WriteLine(x * r);
        }
        static void task26()
        {
            Console.WriteLine("Дано натуральное число n. Вывести на экран решения всех квадратных уравнений вида x2 + 2ax – 3 = 0 для всех a от 1 до n.");
            int a, i;
            double x1, x2;
            a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                x1 = Math.Sqrt(i * i + 3) - i;
                x2 = -Math.Sqrt(i * i + 3) - i;
                Console.Write(x1);
                Console.Write(" ");
                Console.WriteLine(x2);
            }
        }
        static void task27()
        {
            Console.WriteLine("Дано натуральное число n, вещественное число x и набор вещественных чисел an, an-1, ..., a0. Вычислить значение многочлена n-ной степени с коэффициентами an, an-1, ..., a0 от одной переменной в точке x.");
            int n, i;
            double a, x, r;
            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            r = 0;
            for (i = 1; i <= n + 1; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());
                r = r * x + a;
            }
            Console.WriteLine(r);
        }
        static void task28()
        {
            Console.WriteLine("Дано натуральное число n (которое также может быть равно нулю). Вычислить n!");
            int n, i, s;
            n = Convert.ToInt32(Console.ReadLine());
            s = 1;
            for (i = 1; i <= n; i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);
        }
        static void task29()
        {
            Console.WriteLine("Даны натуральные числа n и k (k не превышает n). Вычислить число сочетаний из n по k.");
            int n, i, k, num, d;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            num = 1;
            for (i = n; i >= n - k + 1; i--)
            {
                num = num * i;
            }
            d = 1;
            for (i = 1; i <= k; i++)
            {
                d = d * i;
            }
            Console.WriteLine(num / d);
        }
        static void task30()
        {
            Console.WriteLine("Дано натуральное число n, меньшее 256. Используя псевдографику, вывести на экран таблицу квадратов и кубов всех натуральных чисел от 1 до n включительно.");
            int n, i;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("/-----------------------------------------------------------\\");
            Console.WriteLine("|   x               |   x^2             |   x^3             |");
            Console.WriteLine("|-----------------------------------------------------------|");
            for (i = 1; i <= n; i++)
            {
                Console.Write("|\t");
                Console.Write(i);
                Console.Write("\t\t\t\t|\t");
                Console.Write(i * i);
                Console.Write("\t\t\t\t|\t");
                Console.Write(i * i * i);
                Console.Write("\t\t\t\t|\n");
            }
            Console.WriteLine("\\-----------------------------------------------------------/");
        }
        static void task31()
        {
            Console.WriteLine("Дано натуральное число n заранее неизвестной разрядности. Сформировать и вывести на экран число, представляющее собой реверсную запись n.");
            int n, r;
            n = Convert.ToInt32(Console.ReadLine());
            r = 0;
            while (n != 0)
            {
                r = r * 10;
                r = r + n % 10;
                n = n / 10;
            }
            Console.WriteLine(r);
        }
        static void task32()
        {
            Console.WriteLine("Дано натуральное число n. Проверить, представляют его ли цифры его восьмеричной записи строго монотонную последовательность. При этом последовательность из одной цифры считать строго монотонной.");
            int n, a, b, delta;
            n = Convert.ToInt32(Console.ReadLine());
            b = n % 8;
            n = n / 8;
            a = n % 8;
            n = n / 8;
            delta = a - b;
            while (n != 0)
            {
                b = a;
                a = n % 8;
                n = n / 8;
                if (delta * (a - b) <= 0) break;
            }
            Console.WriteLine(delta * (a - b) > 0);
        }
        static void task33()
        {
            Console.WriteLine("Дано натуральное число n (n > 1). Получить его каноническое разложение на простые сомножители, то есть представить в виде произведения простых сомножителей. При этом в разложении допустимо указывать множитель 1. Например, 264 = 2 * 2 * 2 * 3 * 11 (программе допустимо выдать ответ 264 = 1 * 2 * 2 * 2 * 3 * 11).");
            int n, p;
            p = 2;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(n + " = 1");
            while (n != 1)
            {
                if (n % p == 0)
                {
                    Console.Write("*" + p);
                    n = n / p;
                }
                else p++;
            }
            Console.WriteLine();
        }
        static void task34()
        {
            Console.WriteLine("Даны два натуральных числа одинаковой десятичной разрядности. Сформировать из них третье число так, чтобы цифры первого числа стояли на нечетных местах третьего, а цифры второго – на четных. При этом порядки следования цифр сохраняются. Например, при вводе 1234 и 5678 программа должна выдать ответ 15263748  (для наглядности разряды обоих чисел выделены разными цветами).");
            int c, z, a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = 0;
            z = 1;
            while (a != 0)
            {
                c = c + z * (b % 10);
                z = z * 10;
                b = b / 10;
                c = c + z * (a % 10);
                z = z * 10;
                a = a / 10;
            }
            Console.WriteLine(c);
        }
        static void task35()
        {
            Console.WriteLine("Даны натуральные числа x и n (n <= 10). Вывести на экран число x, записанное в системе счисления с основанием n.");
            int x, n, r, z;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            r = 0;
            z = 1;
            while (x != 0)
            {
                r = r + z * (x % n);
                x = x / n;
                z = z * 10;
            }
            Console.WriteLine(r);
        }
        static void task36()
        {
            Console.WriteLine("Даны натуральные числа m и n. Вывести на экран их наименьший нетривиальный делитель или сообщить, что его нет. ");
            int m, n, min, mindiv, i;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            mindiv = 1;
            if (n < m) min = n;
            else min = m;
            for (i = 2; i <= n; i++)
            {
                if ((n % i == 0) && (m % i == 0))
                {
                    mindiv = i;
                    break;
                }
            }
            if (mindiv != 1)
                Console.WriteLine(mindiv);
            else
                Console.WriteLine("No divisors.");
        }
        static void task37()
        {
            Console.WriteLine("Дано натуральное число n. Проверить, является ли оно счастливым билетом. Например, число 14350 – счастливый билет, так как 1 + 4 = 5 + 0, а центральную цифру мы отбросили.");
            int n, a, l, r, d, i;
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            d = 0;
            while (a != 0)
            {
                a = a / 10;
                d++;
            }
            l = 0;
            r = 0;
            for (i = 1; i <= d / 2; i++)
            {
                r = r + n % 10;
                n = n / 10;
            }
            if (d % 2 == 1) n = n / 10;
            for (i = 1; i <= d / 2; i++)
            {
                l = l + n % 10;
                n = n / 10;
            }
            Console.WriteLine(l == r);
        }
        static void task38()
        {
            Console.WriteLine("Дано натуральное число n. Проверить, представляет ли собой палиндром его десятичная запись.");
            int n, a, r, d, i;
            n = Convert.ToInt32(Console.ReadLine());
            a = n;
            d = 0;
            while (a != 0)
            {
                a = a / 10;
                d++;
            }
            r = 0;
            for (i = 1; i <= d / 2; i++)
            {
                r = r * 10;
                r = r + n % 10;
                n = n / 10;
            }
            if (d % 2 == 1) n = n / 10;
            Console.WriteLine(n == r);
        }
        static void task39()
        {
            Console.WriteLine("Дано натуральное число n. Проверить, представляет ли оно собой натуральную степень числа 2.");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                if (n % 2 == 1) break;
                n = n / 2;
            }
            Console.WriteLine(n == 1);
        }
        static void task40()
        {
            Console.WriteLine("Дана последовательность натуральных чисел, ограниченная вводом нуля. Вывести на экран произведение четных элементов этой последовательности. При этом ноль не считается членом последовательности.");
            int a, p;
            a = Convert.ToInt32(Console.ReadLine());
            p = 1;
            while (a != 0)
            {
                if (a % 2 == 0) p = p * a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (p != 1) Console.WriteLine(p);
            else Console.WriteLine("No such elements!");
        }
        static void task41()
        {
            Console.WriteLine("Дано натуральное число n, а затем последовательность натуральных чисел, ограниченная вводом нуля. Вывести на экран произведение двузначных элементов этой последовательности, которые делятся на n.");
            int a, p, n;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            p = 1;
            while (a != 0)
            {
                if ((a > 9) && (a < 100) && (a % n == 0)) p = p * a;
                a = Convert.ToInt32(Console.ReadLine());
            }
            if (p != 1) Console.WriteLine(p);
            else Console.WriteLine("No such elements!");
        }
        static void task42()
        {
            Console.WriteLine("Дана последовательность натуральных чисел, ограниченная вводом нуля. Вывести на количество простых членов этой последовательности.");
            int a, s, c, i;
            a = Convert.ToInt32(Console.ReadLine());
            c = 0;
            while (a != 0)
            {
                s = 0;
                for (i = 1; i <= a; i++)
                {
                    if (a % i == 0) s++;
                }
                if (s == 2) c++;
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(c);
        }
        static void task43()
        {
            Console.WriteLine("Дана последовательность натуральных чисел, ограниченная вводом нуля. Проверить, начинается ли каждый из ее членов (со второго) с десятичной цифры, на которую оканчивается предыдущий. Например, таковой последовательностью будет являться 14 47 712 2179 9 9 93 0 (также сохранен ограничивающий ноль).");
            int a, b, f, l;
            f = 1;
            l = 0;
            a = Convert.ToInt32(Console.ReadLine());
            b = 0;
            if (a != 0) b = Convert.ToInt32(Console.ReadLine());
            while (b != 0)
            {
                l = a % 10;
                f = b;
                while (f > 9) f = f / 10;
                if (l != f) break;
                a = b;
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(l = f);
        }
        static void task44()
        {
            Console.WriteLine("Дана последовательность из трех и более натуральных чисел, ограниченная вводом нуля. Проверить, является ли эта последовательность пилообразной.");
            int l, m, r;
            l = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            while (r != 0)
            {
                if ((l - m) * (r - m) <= 0) break;
                l = m;
                m = r;
                r = Convert.ToInt32(Console.ReadLine());
            }
            if (r == 0) r = l;
            Console.WriteLine((l - m) * (r - m) > 0);
        }
        static void task45()
        {
            Console.WriteLine("Дана последовательность натуральных чисел, ограниченная вводом нуля. Проверить, является ли эта последовательность строго монотонной.");
            int a, b, d;
            a = Convert.ToInt32(Console.ReadLine());
            if (a != 0) b = Convert.ToInt32(Console.ReadLine());
            else b = 0;
            d = a - b;
            while (b != 0)
            {
                if (d * (a - b) <= 0) break;
                a = b;
                b = Convert.ToInt32(Console.ReadLine());
            }
            if (a == 0) b = 1;
            Console.WriteLine(b == 0);
        }
        static void task46()
        {
            Console.WriteLine("Дано натуральное n (которое также может быть равно 0). Вывести на экран n-ное число Фибоначчи. Нулевой член последовательности – это число 0, 1-й член – число 1, а любой другой член, начиная со 2-го, является суммой двух предыдущих. Например, F2 = F1 + F0 = 1 + 0 = 1, F3 = F2 + F1 = 1 + 1 = 2 и т. д.");
            int f0, f1, f, i, n;
            n = Convert.ToInt32(Console.ReadLine());
            f0 = 0;
            f1 = 1;
            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                f0 = f1;
                f1 = f;
            }
            if (n == 0) f1 = 0;
            Console.WriteLine(f1);
        }
        static void task47()
        {
            Console.WriteLine("Дано натуральное n (которое также может быть равно 0). Вывести на экран сумму чисел Фибоначчи до n-ного включительно. Например, при n = 3 нам необходимо получить сумму 0-го, 1-го, 2-го и 3-го членов последовательности.");
            int f0, f1, f, i, s, n;
            n = Convert.ToInt32(Console.ReadLine());
            f0 = 0;
            f1 = 1;
            if (n == 0) s = 0;
            else s = 1;
            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                s = s + f;
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine(s);
        }
        static void task48()
        {
            Console.WriteLine("Дано натуральное n (которое также может быть равно 0). Вывести на экран все числа Фибоначчи до n-ного включительно.");
            int f0, f1, f, i, n;
            n = Convert.ToInt32(Console.ReadLine());
            f0 = 0;
            f1 = 1;
            Console.Write(f0 + " ");
            if (n != 0) Console.Write(f1 + " ");
            for (i = 2; i <= n; i++)
            {
                f = f1 + f0;
                Console.Write(f + " ");
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine();
        }
        static void task49()
        {
            Console.WriteLine("Дана последовательность символов ')' и '(' длины n (n >= 1). Введите n, а потом все символы одной строчкой. Проверить баланс круглых скобок в этом выражении. Например, при вводе выражения (())() программа должна сообщить о правильности расстановки скобок, а при вводе выражения ((()) – о неправильности.");
            int i, n, count;
            string c;
            n = Convert.ToInt32(Console.ReadLine());
            c = Console.ReadLine();
            count = 0;
            for (i = 1; i <= n; i++)
            {
                if (c[i - 1] == '(') count++;
                if (c[i - 1] == ')') count--;
                if (count == -1) break;
            }
            Console.WriteLine(count == 0);
        }
        static void task50()
        {
            Console.WriteLine("Дано действительное число x и точность eps(1>eps>0.007). Вычислить значение экспоненциальной функции (то есть, показательной функции e в степени x, где e – математическая константа, ) в точке x с заданной точностью eps с помощью ряда Тейлора");
            double eps, expf, p, x;
            int n;
            x = Convert.ToDouble(Console.ReadLine());
            eps = Convert.ToDouble(Console.ReadLine());
            expf = 1;
            n = 1;
            p = 1;
            while (Math.Abs(p) >= eps)
            {
                p = p * x / n;
                expf = expf + p;
                n++;
            }
            Console.WriteLine(expf);
        }


        static void Main(string[] args)
        {
            string a;
            a = "Y";
            while (a == "Y")
            {


                Console.WriteLine("Задача № 1. Вывести на экран сообщение «Hello World!»\nЗадача № 2. Вывести на экран три числа в порядке, обратном вводу\nЗадача № 3. Вывести на экран квадрат введенного числа\nЗадача № 4. Получить реверсную запись трехзначного числа\nЗадача № 5. Посчитать количество единичных битов числа\nЗадача № 6. Вывести на экран наибольшее из двух чисел\nЗадача № 7. Вывести на экран наибольшее из трех чисел\nЗадача № 8. Вывести название дня недели по его номеру\nЗадача № 9. Проверить, является ли четырехзначное число палиндромом\nЗадача № 10. Проверить, является ли четырехзначное число счастливым билетом\nЗадача № 11. Проверить, является ли двоичное представление числа палиндромом\nЗадача № 12. Решить квадратное уравнение\nЗадача № 13. Вывести на экран все натуральные числа до заданного\nЗадача № 14. Найти наибольший нетривиальный делитель натурального числа\nЗадача № 15. Найти наименьший нетривиальный делитель натурального числа\nЗадача № 16. Подсчитать общее число делителей натурального числа\nЗадача № 17. Проверить, является ли заданное натуральное число простым\nЗадача № 18. Вывести на экран все простые числа до заданного");
                Console.WriteLine("Задача № 19. Вывести на экран первых n простых чисел\nЗадача № 20. Проверить, является ли заданное натуральное число совершенным\nЗадача № 21. Проверить, являются ли два натуральных числа дружественными\nЗадача № 22. Найти наибольший общий делитель двух натуральных чисел\nЗадача № 23. Найти наименьшее общее кратное двух натуральных чисел\nЗадача № 24. Вычислить xn\nЗадача № 25. Вычислить xn по алгоритму быстрого возведения в степень\nЗадача № 26. Решить квадратное уравнение заданного вида с параметром\nЗадача № 27. Вычислить значение многочлена в точке\nЗадача № 28. Вычислить факториал\nЗадача № 29. Вычислить число сочетаний из n по k\nЗадача № 30. Вывести таблицу квадратов и кубов всех натуральных чисел до n\nЗадача № 31. Сформировать реверсную запись заданного числа\nЗадача № 32. Проверить монотонность последовательности цифр числа\nЗадача № 33. Получить каноническое разложение числа на простые сомножители\nЗадача № 34. Сформировать число из двух заданных чередованием разрядов\nЗадача № 35. Вывести на экран x, записанное в системе счисления с основанием n");
                Console.WriteLine("Задача № 36. Найти наименьший нетривиальный делитель двух заданных чисел\nЗадача № 37. Проверить, является ли натуральное число счастливым билетом\nЗадача № 38. Проверить, является ли натуральное число палиндромом\nЗадача № 39. Проверить, является ли натуральное число степенью двойки\nЗадача № 40. Вывести на экран произведение четных элементов заданной последовательности натуральных чисел\nЗадача № 41. Вывести на экран произведение двузначных элементов последовательности натуральных чисел, которые делятся на заданное число\nЗадача № 42. Найти количество простых членов последовательности\nЗадача № 43. Проверить, начинается ли каждый из членов последовательности с десятичной цифры, на которую оканчивается предыдущий\nЗадача № 44. Проверить, является ли последовательность пилообразной\nЗадача № 45. Проверить, является ли последовательность строго монотонной\nЗадача № 46. Вывести на экран n-ное число Фибоначчи\nЗадача № 47. Вывести на экран сумму чисел Фибоначчи до n-ного включительно\nЗадача № 48. Вывести на экран все числа Фибоначчи до n-ного включительно\nЗадача № 49. Проверить баланс круглых скобок в символьном выражении\nЗадача № 50. Вычислить экспоненту с заданной точностью\n");


                Console.WriteLine("Пожалуйста, вводите числа и строчки через Enter");
                Console.WriteLine("Напечатайте число от 1 до 50 - номер нужной задачи.");
                int n = Convert.ToInt32(Console.ReadLine());
                while ((n < 1) || (n > 50))
                {
                    Console.WriteLine("Наверное вы опечатались.");
                    Console.WriteLine("Напечатайте число от 1 до 50 - номер нужной задачи.");
                    n = Convert.ToInt32(Console.ReadLine());
                }


                string m;
                switch (n)
                {
                    case 1:
                        m = "Y";
                        while (m == "Y")
                        {
                            task1();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 2:
                        m = "Y";
                        while (m == "Y")
                        {
                            task2();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 3:
                        m = "Y";
                        while (m == "Y")
                        {
                            task3();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 4:
                        m = "Y";
                        while (m == "Y")
                        {
                            task4();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 5:
                        m = "Y";
                        while (m == "Y")
                        {
                            task5();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 6:
                        m = "Y";
                        while (m == "Y")
                        {
                            task6();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 7:
                        m = "Y";
                        while (m == "Y")
                        {
                            task7();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 8:
                        m = "Y";
                        while (m == "Y")
                        {
                            task8();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 9:
                        m = "Y";
                        while (m == "Y")
                        {
                            task9();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 10:
                        m = "Y";
                        while (m == "Y")
                        {
                            task10();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 11:
                        m = "Y";
                        while (m == "Y")
                        {
                            task11();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 12:
                        m = "Y";
                        while (m == "Y")
                        {
                            task12();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 13:
                        m = "Y";
                        while (m == "Y")
                        {
                            task13();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 14:
                        m = "Y";
                        while (m == "Y")
                        {
                            task14();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 15:
                        m = "Y";
                        while (m == "Y")
                        {
                            task15();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 16:
                        m = "Y";
                        while (m == "Y")
                        {
                            task16();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 17:
                        m = "Y";
                        while (m == "Y")
                        {
                            task17();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 18:
                        m = "Y";
                        while (m == "Y")
                        {
                            task18();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 19:
                        m = "Y";
                        while (m == "Y")
                        {
                            task19();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 20:
                        m = "Y";
                        while (m == "Y")
                        {
                            task20();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 21:
                        m = "Y";
                        while (m == "Y")
                        {
                            task21();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 22:
                        m = "Y";
                        while (m == "Y")
                        {
                            task22();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 23:
                        m = "Y";
                        while (m == "Y")
                        {
                            task23();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 24:
                        m = "Y";
                        while (m == "Y")
                        {
                            task24();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 25:
                        m = "Y";
                        while (m == "Y")
                        {
                            task25();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 26:
                        m = "Y";
                        while (m == "Y")
                        {
                            task26();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 27:
                        m = "Y";
                        while (m == "Y")
                        {
                            task27();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 28:
                        m = "Y";
                        while (m == "Y")
                        {
                            task28();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 29:
                        m = "Y";
                        while (m == "Y")
                        {
                            task29();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 30:
                        m = "Y";
                        while (m == "Y")
                        {
                            task30();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 31:
                        m = "Y";
                        while (m == "Y")
                        {
                            task31();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 32:
                        m = "Y";
                        while (m == "Y")
                        {
                            task32();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 33:
                        m = "Y";
                        while (m == "Y")
                        {
                            task33();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 34:
                        m = "Y";
                        while (m == "Y")
                        {
                            task34();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 35:
                        m = "Y";
                        while (m == "Y")
                        {
                            task35();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 36:
                        m = "Y";
                        while (m == "Y")
                        {
                            task36();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 37:
                        m = "Y";
                        while (m == "Y")
                        {
                            task37();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 38:
                        m = "Y";
                        while (m == "Y")
                        {
                            task38();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 39:
                        m = "Y";
                        while (m == "Y")
                        {
                            task39();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 40:
                        m = "Y";
                        while (m == "Y")
                        {
                            task40();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 41:
                        m = "Y";
                        while (m == "Y")
                        {
                            task41();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 42:
                        m = "Y";
                        while (m == "Y")
                        {
                            task42();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 43:
                        m = "Y";
                        while (m == "Y")
                        {
                            task43();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 44:
                        m = "Y";
                        while (m == "Y")
                        {
                            task44();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 45:
                        m = "Y";
                        while (m == "Y")
                        {
                            task45();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 46:
                        m = "Y";
                        while (m == "Y")
                        {
                            task46();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 47:
                        m = "Y";
                        while (m == "Y")
                        {
                            task47();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 48:
                        m = "Y";
                        while (m == "Y")
                        {
                            task48();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 49:
                        m = "Y";
                        while (m == "Y")
                        {
                            task49();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                    case 50:
                        m = "Y";
                        while (m == "Y")
                        {
                            task50();
                            Console.WriteLine("Хотите попробывать другие данные?(Y/N)");
                            m = Console.ReadLine();
                        }
                        break;
                }


                Console.WriteLine("Хотите попробывать другую задачу?(Y/N)");
                a = Console.ReadLine();
            }
        }
    }
}