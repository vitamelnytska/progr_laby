using System;
using System.Collections.Generic;
using System.Text;

namespace lab8_cs
{
    class RowOperations
    {
        public delegate void CountLower(string str); //створення делегата
        private string abc_ { get; set;} //поле  - рядок
        public RowOperations(string Abc) { abc_ = Abc; } //коструктор
        public static void SlittleABC(string Abc) //статичний метод підрахування малих літер

        {
            int count = 0;
            
            for (int i = 0; i < Abc.Length; i++)
            {
                if (char.IsLower(Abc[i]))
                    count++;
            }
            Console.WriteLine(count);
        }
        //екземплярний метод підрахування малих літер
        public void littleABC(string s)
        {
            abc_ = s;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                    count++;
            }
            Console.WriteLine(count);
        }
        

    }
}
