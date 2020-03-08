using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyText
    {
        //ініціалізація тексту з рядків
        String[] text;
        int size;
        
        //метод додавання
        public void addRow(String str)
        {
            //перетворюмо наш текст і виводимо рядок
            
            Array.Resize(ref text, ++size);
            text[size - 1] = str;


        }

        //міняємо місцями
        public void replace(int index, String str)
        {
            text[index - 1] = str;
        }
        public void clean()
        {
            //заміняємо наші рядки  пустими, тим самим очищуємо текст
            String[] text_t = new String[0];
            text = text_t;
            size = 0;
        }
        public void delete(int index)//видаляємо вказаний рядок
        {
            index--; //при цьому зменшуємо індекс
            var arr = new String[text.Length - 1]; //зменш. розмір нашого тексту
            for (int i = 0; i < index; i++) //тобто по порядку присвоюємо індекс наступному рядку
            {
                arr[i] = text[i];
            }
            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = text[i + 1];
            }
            text = arr;
            size--;
        }
        public void print() //метод виведення тексту
        {
            Console.WriteLine("------------------------------");
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine(i + 1 + ":");
                Console.WriteLine(text[i].first);
            }

            Console.WriteLine("------------------------------");
        }
        public int count_str() //підрахування к-сті рядків
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                count++;
            return count;
        }



        public void strings() //пошук цифрів у тексті
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tMy text:");
            double val; 
            string ab = string.Empty; //створяємо пустий рядок
            StringBuilder rer = new StringBuilder(); //для того щоб зробити з усіх рядків  - один(наш текст у форматі рядка)
            string qw = string.Empty; //ще один пустий рядок
            for (int i = 0; i < size; i++)
            {

                rer.Append(text[i].first); //рядок(наш текст)

            }
            for (int j = 0; j < rer.Length; j++)
            {
                if (Char.IsDigit(rer[j])) //перевірка елементів на символ-цифру
                {
                    ab += rer[j];
                }
                if (ab.Length > 0)
                { 
                    val = double.Parse(ab);

                }
            }




            Console.WriteLine(rer);
            Console.WriteLine("\nnumbers: " + ab);

            Console.WriteLine("------------------------------");
        }



    

}
}
