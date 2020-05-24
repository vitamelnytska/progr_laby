using System;
//Мельницька Віталія ІС-92

namespace lab_7_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a = { 6, 7, 8, 3, -4, -6, -7 }; //наш масив з якого зробимо список
            float[] b = { 6, 7, 8, 3, -4, -6, -7, 9 };
            List f=new List(); //створюємо об'єктu списку
            List g = new List();
            foreach (float el in a) { //для кожного члена масиву створюємо вузол в списку
                Node node = f.CreateNode(el); 
                f.AddFirst(node); //додаючи його в початок списку

            }
            float aver = f.Average(); //шукаємо середнє значення
            f.print(); //виводимо список
            Console.WriteLine("average: " + aver); 
            Console.WriteLine("Amount: ");
            Console.WriteLine(f.Count(aver));
            f.DeleteNegative();//видаляємо певні елементи в списку
            f.print();

            foreach (float el in b)
            { //для кожного члена масиву створюємо вузол в списку
                Node node = g.CreateNode(el);
                g.AddFirst(node); //додаючи його в початок списку

            }
            aver = g.Average(); //шукаємо середнє значення
            g.print(); //виводимо список
            Console.WriteLine("average: " + aver);
            Console.WriteLine("Amount: ");
            Console.WriteLine(g.Count(aver));
            g.DeleteNegative();//видаляємо певні елементи в списку
            g.print();

        }
       
    }
}
