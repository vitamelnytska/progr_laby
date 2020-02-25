using System;

namespace lab_1
{
    class Program
    {
        static void Increment(ref int a)
        {
            int x0 = a;
            for (int i = 0; i < sizeof(int) *4; i++) { 
                a = a ^ (1 << i);  
                if ((x0 & (1 << i)) == 0) break; //коли операція або == 0, виходимо з циклу
            }
           
        }
        static string greater_than(int number1, int number2)
        {

            int key = Convert.ToString(Math.Abs(Math.Max(number1, number2)), 2).Length; //переводимо числа в рядок цифр 
            for (int i = key; i >= 0; i--)
            {
                if ((number1 & (number1 << i)) > (number2 & (number2 << i))) //порівнюємо їхні біти 
                {
                    return $"Число {number1} > {number2}";
                }
                 else if ((number1 & (number1 << i)) < (number2 & (number2 << i)))
                break;
        }
                return $"Число {number1} не є бiльшим за число {number2}";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Melnytska Vitaliya IS-92");
            Console.WriteLine("Enter a value:");
            
            int x = Convert.ToInt32(Console.ReadLine()); //конвертуємо до розмірності 32 бітів

            Console.WriteLine("value + 1:"); 
            Increment(ref x);              // по ссилці передаємо початкове х
            Console.WriteLine(x);  //виводимо х, яке опрацьоване уже в функції

            Console.WriteLine("Enter two numbers:"); 
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(greater_than(a,b)); 
        }

    }
}
