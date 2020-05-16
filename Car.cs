using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyLibrary
{
    public class Car
    {
        public delegate void EventCar(object sender,string message); //делегат
        public event EventCar MaxSpeeding; //подія

        private int _speed {get;set;} // швидкість
        public int _fuel { get; private set; } // пальне
        public int _MaxSpeed { get; private set; } // максимальна допустима швидкість
        public Car( int speed, int fuel, int max) { _speed = speed; _fuel = fuel; _MaxSpeed = max; } //конструктор
        public void StartMoving(bool flag) //метод початок руху
        {
            if (flag is true)
            {
                Console.WriteLine("The car started to move\n speed is increases ");

            }
        }
        public void Move(int plus_fuel) //метод рух
        {
            for (int i = _speed; i <= _MaxSpeed; i++)
            {

                
                Console.WriteLine(_speed);
                if (_speed > _MaxSpeed && MaxSpeeding != null)//якщо швидкість перевищена
                {
                    MaxSpeeding(this, "Car exceeded max speed");
                    Console.WriteLine($"fuel is {_fuel}");
                    break;
                }
                _speed +=2;

                DecreasFuel(); //коли машина рухається - пальне зменшується



            }
        }
        //метод зупинки машини
        public void FinishMove() { _speed = 0; Console.WriteLine( "Car is stopped"); }
        public void DecreasFuel() //метод трати палива
        {

                _fuel--;
                
        }
        public void Refueling(int plus_fuel) {//зметод заправлення машини
                    _fuel+=plus_fuel;                
                Console.WriteLine( $"car is refueled: {_fuel}");
        }
        
        
        public static void Handler(object sender, string mes) //статичний метод на подію
        {
            Console.WriteLine($"car event: {mes}");
        }
        
        
    }
}
