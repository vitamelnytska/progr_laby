using System;
using MyLibrary;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(0, 7, 10); //створюємо об'єкт "машину"
            auto.MaxSpeeding += Car.Handler; //підписуємось на подію перевищення швидкості
            auto.StartMoving(true); //машина починає рухатись
            auto.Move(10); //машина рухається
            auto.FinishMove(); //зупинка машини
            auto.Refueling(3); //заправка машини
            
        }

       
    }

}
