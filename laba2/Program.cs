using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1, типы 

            //byte b = 26;
            //sbyte sb = -13;
            //long l = -2344;
            //ulong ul = 33343543;
            //short sh = -32500;
            //ushort ush = 65530;
            //int i = -1231213;
            //uint ui = 4000000;
            //char ch = 'a';
            //bool bl = false;
            //float fl = 1234.43234f;
            //double db = 45345.45345f;
            //decimal dec = 397845623798465;
            //string str = "string";
            //object obj1 = "Object";
            //object obj2 = 123765;
            //WriteLine("byte: " + b);
            //WriteLine("sbyte: " + sb);
            //WriteLine("long: " + l);
            //WriteLine("ulong: " + ul);
            //WriteLine("short: " + sh);
            //WriteLine("ushort: " + ush);
            //WriteLine("int: " + i);
            //WriteLine("uint: " + ui);
            //WriteLine("char: " + ch);
            //WriteLine("bool: " + bl);
            //WriteLine("float: " + fl);
            //WriteLine("double: " + db);
            //WriteLine("decimal: " + dec);
            //WriteLine("string: " + str);
            //WriteLine("object1: " + obj1);
            //WriteLine("object2: " + obj2);
            //ReadLine();

            //5 примеров неявного приведения типов:
            //int npriw1 = 54;
            //double npriw_1 = npriw1;

            //byte npriw2 = 22;
            //short npriw_2 = npriw2;

            //ulong npriw3 = 214432;
            //decimal npriw_3 = npriw3;

            //sbyte npriw4 = 123;
            //int npriw_4 = npriw4;

            //ushort npriw5 = 522;
            //float npriw_5 = npriw5;

            ////5 примеров явного приведения типов:
            //int priw1 = 15;
            //float priw_1;
            //priw_1 = (float)priw1;

            //double priw2 = 234.543f;
            //int priw_2;
            //priw_2 = (int)priw2;

            //float priw3 = 543.654f;
            //short priw_3;
            //priw_3 = (short)priw3;

            //sbyte priw4 = 76;
            //double priw_4;
            //priw_4 = (double)priw4;

            //decimal priw5 = 3428942;
            //uint priw_5;
            //priw_5 = (uint)priw5;

            ////пример использования Convert
            //bool conv1 = true;
            //double conv_1 = Convert.ToDouble(conv1);

            ////упаковка и распаковка значимой переменной
            //int num1 = 1234;
            //object box = num1;
            //int unbox = (int)num1;

            ////работа с неявно типизированной переменной
            //var no_type = 134;
            //int num2 = 12442;
            //int result;
            //result = num2 + no_type;
            //WriteLine(result);


            //string str1 = "dswfwdgdsfsdf";
            //string str2 = "ewtgfbgfefrfegdsfgsdfg";
            //WriteLine(String.Compare(str1, str2));

            //string str1 = "21452regfsd";
            //string str2 = "sfegre33grfegfe";
            //string str3 = " dsgrefgbrhtr446";
            //string result = str1 + str2 + str3;
            //WriteLine(result);
            //Выделение подстроки
            //string str4 = str1.Substring(4, 6);
            //WriteLine(str4);
            ////Разделение строки на слова
            //string[] split = str2.Split(new char[] { 'f' }); //f - символ до которого будет выводится каждое слово, сам сивол не выводится...
            //foreach (string output_of_words in split)
            //{
            //    WriteLine(output_of_words);
            //}
            ////Вставка строки в другую строку с заданной позиции
            //str2 = str2.Insert(8, str3);
            //WriteLine(str2);
            ////удаление подстроки
            //str1 = str1.Substring(3);
            //WriteLine(str1);
            ////интерполяция строк:
            //WriteLine($"строка 1: {str1}\nстрока 2: {str2}\nстрока 3: {str3}");

            // Работа с пустой строкой и строкой NULL(string.IsNullOrEmpty)
            //string str1 = null;
            //string str2 = "";
            //string str3 = "eegtreterrrg";
            //bool isempty = String.IsNullOrEmpty(str1);
            //WriteLine("Строка 1:" + isempty);
            //isempty = String.IsNullOrEmpty(str2);
            //WriteLine("Строка 2:" + isempty);
            //isempty = String.IsNullOrEmpty(str3);
            //WriteLine("Строка 2:" + isempty);

            //Работа со StringBuilder
            //StringBuilder str1 = new StringBuilder("Itadakimas!!");
            //str1.Remove(2, 1); /*
            //                   * удаление определённых символов*/
            //str1.Remove(5, 1);
            //str1 = str1.AppendFormat("!!!!"); //Вставка в конец строки
            //str1 = str1.Insert(0, "OOOOh"); //Вставка в начало строки
            //WriteLine(str1);

            //МАССИВЫ
            // Вывод двумерного массива, как матрицу:
            //int[,] array1 = { { 2, 3, 4, 5 }, { 9, 4, 1, 3 }, { 10, 5, 13, 23 }, { 18, 0, 9, 3 } };
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Write(array1[i, j] + " ");
            //    }
            //    WriteLine(" ");
            //}

            //Работа с одномерным массивом строк, вывод его содержимогоБ его длины и замена одного элемента на выбор пользователя:
            //string[] arr1 = { "element1", "element2", "element3", "element4", "element5" };
            //for (int i = 0; i < 5; i++)
            //{
            //    WriteLine(arr1[i]);
            //}
            //WriteLine("Длина массива: " + arr1.Length);
            //WriteLine("Введите индекс элемента,который нужно заменить(отсчёт с 0): ");
            //int take = Convert.ToInt32(Console.ReadLine());
            //WriteLine("Введите чем нужно заменить элемент: ");
            //string replace = Console.ReadLine();
            //arr1[take] = replace;
            //for (int i = 0; i < 5; i++)
            //{
            //    WriteLine(arr1[i]);
            //}

            //работа со ступенчатым массивом
            //double[][] arr1 = new double[3][];
            //arr1[0] = new double[2];
            //arr1[1] = new double[3];
            //arr1[2] = new double[4];
            //double yours_numb;
            //for (int i = 0; i < 2; i++)
            //{
            //    WriteLine("Введите элемент номер " + i + " в первой строке");
            //    string nb = Console.ReadLine();
            //    yours_numb = Convert.ToDouble(nb);
            //    arr1[0][i] = yours_numb;
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    WriteLine("Введите элемент номер " + i + " во второй строке");
            //    string nb = Console.ReadLine();
            //    yours_numb = Convert.ToDouble(nb);
            //    arr1[1][i] = yours_numb;
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    WriteLine("Введите элемент номер " + i + " в третьей строке");
            //    string nb = Console.ReadLine();
            //    yours_numb = Convert.ToDouble(nb);
            //    arr1[2][i] = yours_numb;
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    Write(arr1[0][i] + " ");
            //}
            //WriteLine(" ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Write(arr1[1][i] + " ");
            //}
            //WriteLine(" ");
            //for (int i = 0; i < 4; i++)
            //{
            //    Write(arr1[2][i] + " ");
            //}
            //WriteLine(" ");

            ////неявно типизированные переменные для хранения строки и массива:
            //var str1 = "w12erefdfdsc";
            //var arr1 = new[] { 1, 2, 3, 4, 5 };

            //КОРТЕЖИ
            //кортеж из 5 разных элементов и вывод его элементов
            //(int, string, char, string, ulong) kor = (132, "string", 'c', "string2", 1234312232);
            //WriteLine(kor.Item1);
            //WriteLine(kor.Item3);
            //WriteLine(kor.Item4);
            //WriteLine(kor);
            //////распаковка кортежа, первый способ:    
            //var a = kor.Item1;
            //var b = kor.Item2;
            //var c = kor.Item3;
            //var d = kor.Item4;
            //var e = kor.Item5;
            ////// распаковка кортежа, второй способ:
            //var (kor1, kor2, kor3) = (123, 234.5f, "string");

            //// работа с пустой переменной(_)
            //var (per1, _, _, per4, per5, _) = ("2134", "142432", "fdgfrefwe", "1234fdss", "wrfe334f", "fdefwee3");
            //WriteLine(per1 + "  " + per4 + " " + per5);

            ////Сравнение кортежей
            //var t1 = (150, 435);
            //var t2 = (150, 435);
            //WriteLine(t1 == t2);
            //WriteLine(t1 != t2);

            //////Работа с функцией
            //int[] arr1 = { 4, 5, 6, 123, 10, 128 };
            //string str = "wetringwerew";
            //var result = func(arr1, str);
            //WriteLine(result); //вывод кортежа со всеми нужными значениями
            //static (int max, int min, int summ, char lit) func(int[] arr1_on_function, string str_on_function)
            //{//Функция для работы с массивом и строкой
            //    int a = 0;
            //    int b = 0;
            //    int summa = 0;
            //    char symb;
            //    for (int i = 1; i < arr1_on_function.Length; i++)
            //    {
            //        if (arr1_on_function[a] < arr1_on_function[i])
            //        {
            //            a = i;
            //        }
            //    }
            //    WriteLine(arr1_on_function[a]);
            //    a = arr1_on_function[a]; //получение максимального элемента в массиве...
            //    for (int i = 1; i < arr1_on_function.Length; i++)
            //    {
            //        if (arr1_on_function[b] > arr1_on_function[i])
            //        {
            //            b = i;
            //        }
            //    }
            //    WriteLine(arr1_on_function[b]);
            //    b = arr1_on_function[b]; //получение минимального элемента в массиве...
            //    for (int i = 0; i < arr1_on_function.Length; i++)
            //    {
            //        summa += arr1_on_function[i]; //получение суммы всех элементов массива
            //    }
            //    symb = Convert.ToChar(str_on_function.Substring(0, 1)); //получение первого символа из строки...
            //    var result = (max: a, min: b, summ: summa, lit: symb);
            //    return result;
            //}


            //Работа с Checked/unchecked
            //unch1();
            //unch2();
            //static int unch1()//функция для работы с checked
            //{
            //    int a;
            //    int num1 = 2147483647;
            //    a = checked(num1);
            //    return num1;
            //}
            //static int unch2() //Функция для работы с unchecked
            //{
            //    int a;
            //    int num1 = 2147483647;
            //    a = unchecked(num1 + 1);
            //    return num1;
            //}

            ReadLine();
        }
    }
}
