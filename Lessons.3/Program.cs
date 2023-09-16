using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessons._3
{
    internal class Program
    {
        /// <summary>
        /// ·	Напечатать весь массив целых чисел
        /// </summary>
        static void Exmpl01()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        /// <summary>
        /// ·	Найти индекс максимального значения в массиве (воспользоваться функцией)
        /// </summary>
        static void Exmpl02(int[] arr)
        {
            int max = arr[0];
            int num= 0;
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    num = i;
                }
            }
            Console.WriteLine($"индекс максимального значения: {num}");

        }

        /// <summary>
        /// ·	Удалить элемент из массива по индексу.
        /// </summary>
        static void Exmpl03(int[] arr, int index)
        {
            PrintArray(arr);
            int[] temp= new int[arr.Length-1];
            for(int i = 0; i < index; i++)
            {
                temp[i]= arr[i];
            }
            for(int j=index; j<temp.Length; j++)
            {
                temp[j]= arr[j+1];
            }
            arr = temp;
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("");
        }

        static void Exmpl04(int[] arr, int index, int add)
        {
            PrintArray(arr);
            int[] temp = new int[arr.Length + 1];
            temp[index] = add;
            for (int i = 0; i < index; i++)
            {
                temp[i] = arr[i];
            }
            for (int j = index+1; j < temp.Length; j++)
            {
                temp[j] = arr[j - 1];
            }
            arr = temp;
            PrintArray(arr);
        }

        /// <summary>
        /// ·	Дан текст. Определить, есть ли в тексте слово one.
        /// </summary>
        static void Exmpl05(string str)
        {
            string t = "one";
            bool b = false;
            for(int i=0; i<str.Length-2;i++)
            {
                int num = 0;
                for(int  j=0; j<t.Length;j++) 
                {
                    if (str[i+j] == t[j])
                    {
                        num++;
                    }
                }
                if(num==t.Length)
                {
                    b = true;
                    break;
                }
            }
            if (b)
            {
                Console.WriteLine("В этом тексте есть слово: one");
            }
            else
            {
                Console.WriteLine("В этом тексте нет слово: one");
            }
        }

        /// <summary>
        /// ·	Дана строка, посчитать количество вхождений буквы P.
        /// </summary>
        /// <param name="str"></param>
        static void Exmpl06(string str)
        {
            int num = 0;
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] == 'P')
                {
                    num++;
                }
            }
            Console.WriteLine($"количество вхождений буквы P: {num}");
        }

        /// <summary>
        /// ·	Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»
        /// </summary>
        static void Exmpl07()
        {
            string str = "класс";
            Console.WriteLine("Составьте программу, которая в слове «класс» две одинаковые буквы заменяет цифрой «1»");
            string temp = "кла1";
            str=temp;
            Console.WriteLine(str);
        }

        /// <summary>
        /// ·	Написать программу, подсчитывающую количество цифр в заданной строке.
        /// </summary>
        static void Exmpl08(string str)
        {
            Console.WriteLine(str);
            int num = 0;
            string numbers = "0123456789";
            for (int i=0; i < str.Length; i++)
            {
                for(int j=0; j < 10; j++)
                {
                    if (str[i] == numbers[j])
                    {
                        num++;
                    }
                }
            }
            Console.WriteLine($"количество цифр в заданной строке: {num}");
        }

        /// <summary>
        /// ·	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
        /// Например, если было введено число 345, то программа должна вывести число 543.
        /// </summary>
        static void Exmpl09(int n)
        {
            Console.WriteLine(n);
            string number = n.ToString();
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            string reversnumber = new string(charArray);
            Console.WriteLine(reversnumber);
        }

        /// <summary>
        /// 1.	Написать программу, которая считывает символы с клавиатуры,
        /// пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.                 
        /// </summary>
        static void Exmpl10()
        {
            int num = 0;
            while (true)
            {
                Console.Write("Введите символ: ");
                char sim = Convert.ToChar(Console.ReadLine());
                
                if (sim == '.')
                {
                    break;
                }
                if(sim == ' ')
                {
                    num++;
                }
            }
            Console.WriteLine($"Количество пробелов: {num}");

        }

        /// <summary>
        /// ·	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
        /// </summary>
        static void Exmpl11()
        {
            Console.Write("Введите номер трамвайного билета: ");
            string num = Convert.ToString(Console.ReadLine());
            if (num.Length == 6)
            {
                int[] m = new int[6];
                for (int t = 0; t < num.Length; t++)
                {
                    m[t] = (int)num[t];
                }
                int sum1 = m[0] + m[1] + m[2];
                int sum2 = m[3] + m[4] + m[5];
                if (sum1 == sum2)
                {
                    Console.WriteLine("счастливым");
                }
                else
                {
                    Console.WriteLine("не счастливым");
                }
            }
        }

        /// <summary>
        /// ·	Есть строка (любая), нужно удалить из этой строки знаки / и \.
        /// </summary>
        static void Exmpl12(string str)
        {
            string cleanedstr = str.Replace("/", "").Replace("\\", "");

            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Результат после удаления знаков / и \\: " + cleanedstr);
        }

        /// <summary>
        /// ·	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений 
        /// символов верхнего регистра на величину 32. Используя эту информацию, написать программу, 
        /// которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
        /// </summary>
        static void Exmpl13(string str)
        {
            string convertedText = ConvertCase(str);

            Console.WriteLine("Результат конвертации:");
            Console.WriteLine(convertedText);

        }

        static string ConvertCase(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
                else if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }
            return new string(charArray);
        }

        /// <summary>
        /// ·	Ввести небольшой текст (с пробелами) в строку S. Подсчитать количество слов в строке и вывести все слова в столбик.
        /// </summary>
        static void Exmpl14()
        {
            Console.WriteLine("Введите текст с пробелами:");
            string Text = Console.ReadLine();

            string[] words = Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Количество слов в строке: {words.Length}");
            Console.WriteLine("Слова в столбик:");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        /// <summary>
        /// ·	Дан текст. Определить, содержит ли он символы, отличающиеся от букв и цифр.
        /// </summary>
        static void Exmpl15(string str)
        {
            bool b = funcsim(str);

            if (b)
            {
                Console.WriteLine("Текст содержит специальные символы.");
            }
            else
            {
                Console.WriteLine("Текст не содержит специальных символов.");
            }
        }
        static bool funcsim(string str)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.IsMatch(str);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2, 3, 4,5 };
            int n = 2345;
            string str = "htnfmv PP/\\Pkd657489k one";

            Exmpl15(str);

        }
    }
}
