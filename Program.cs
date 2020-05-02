using System;

namespace lab6_exeption_cs
{
    class Expression
    {   
        private double a_, b_, c_;  //вхідні дані   
        public Expression() {a_ = 0; b_ = 0; c_ = 0; } //конструктор за замовчуванням
        public Expression(double a, double b, double c) { a_ = a; b_ = b; c_ = c; } //конструктор з параметрами
        public void Answer() { //перевірка на умови виразу
            try
            {
                if ((41 - b_ / c_ + 1) == 0)
                    throw new DivideByZeroException("(41 - b_ / c_ + 1)=0");
                else if (c_ == 0)
                    throw new DivideByZeroException("c=0");
                else if ((a_ * b_ + 2) <= 0)
                    throw new ArithmeticException("(a_ * b_ + 2) <= 0");
                else print();
            }
            catch (DivideByZeroException)//ловимо помилку ділення на 0
            {
                Console.WriteLine("\t\t\tПомилка: Дiлити на 0 не можна");
            }
            catch (ArithmeticException)//ловимо помилку на умову підлогарифмічного виразу
            {
                Console.WriteLine("\t\t\tПомилка: Пiдлогарифмiчний вираз повинен бути бiльше 0");
            }
        }
        public double calculate() //вирахування виразу
        {
            return (Math.Log10(a_ * b_ + 2) * c_ / (41 - b_ / c_ + 1));
        }
        public void print() { //виведення результату
            Console.WriteLine(calculate());
        }
        public void print_abc() //виведення вхідних даних
        {
            Console.WriteLine(  "a=" + a_ + " b=" + b_ + " c=" + c_  );
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] arr = new Expression[4]; //масив об'єктів вхідних даних
            arr[0] = new Expression(1, 2, 3);
            arr[1] = new Expression(1, 2, 0);
            arr[2] = new Expression(1, 42, 1);
            arr[3] = new Expression(1, -2, 1);
            foreach (Expression el in arr)
            {
                el.print_abc();
                Console.WriteLine("\tExpression log10(a * b + 2) * c / (41 - b / c + 1) = ");
                el.Answer();
            }

        }
    }
}
