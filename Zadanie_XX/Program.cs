using System;
using System.Linq;
namespace Zadanie_XX
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] array = new int[] { 5, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string[] strArray = new string[10];
            
        }
        static void pervoe(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] * 2);
            }

        }
        static void vtoroe(int[] array)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] - a);
            }
        }
        static void tretie(int[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item / array[0]);
            }
        }
        static void chetvertoe(int[] array, int index)
        {
            index = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(array[5]));

        }
        static void FIVE(int[] array)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine((array[a] + array[b]) / 2);
        }
        static void SIX(string[] strArray)
        {
            // 1 легкий (умный) способ решения 
            //string str = Console.ReadLine();
            //strArray = str.Split(' ');
            //Console.WriteLine(string.Join(' ',strArray));
            string str = Console.ReadLine();
            string newstr = String.Empty;
            int i = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == ' ')
                {
                    strArray[i] = newstr;
                    newstr = String.Empty;
                    i++;
                }
                else
                {
                    newstr += str[j];
                }
            }
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

        }
        static void SEVEN()
        {
            string text = "Раз Два Три Четыре Пять";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string first = words[0];
            string last = words[words.Length - 1];
            string temp = String.Empty;
            temp = words[words.Length - 1];
            words[words.Length - 1] = words[0];
            words[0] = temp;
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

        }
        static void Vosem(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }



        }
        static void DEVIAT(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }
        }
}
