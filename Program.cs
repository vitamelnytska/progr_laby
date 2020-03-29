// Melnytska Vitaliya IS-92

using System;

namespace lab_4_cs
{
    class Vector
    {
      
     public int length_; //довжина
     public int angle_; //кут
        public Vector()//конструктор за замовчуванням
        {
            this.angle_ = 0;
            this.length_ = 0;
        }
        public Vector(int length, int angle)  //коструктор з параметрами
        {
            this.length_ = length;
            this.angle_ = angle;
        }
        public Vector(Vector copy)  //конструктор копіювання
        {
            this.length_ = copy.length_;
            this.angle_ = copy.angle_;
        }



        //методи отримання даних вектора
        public int Get_length(){ 
            return length_;
        }
        public int Get_angle()
        {
            return angle_;
         }
        //метод повороту вектору на будь-який кут
        public Vector turn(int angle)
        {
            Vector res = new Vector();
            res.angle_ = Get_angle() + angle;
            res.length_ = Get_length();
            return res;
        }
        //перевантаження оператора додавання
    public static Vector operator +(Vector r,Vector l)
    {
            Vector res = new Vector();
            res.length_ = r.length_ + l.length_;
            res.angle_ = r.angle_ + l.angle_;
            return res;
    }
        //перевантаження оператора ділення
        public static Vector operator /(Vector div, int d)
    {
            Vector res = new Vector();
            res.length_ = div.length_ / d;
            res.angle_= div.angle_;
            return res;
    }
    
    
};
    class Program
    {
        static void Main(string[] args)
        {
            Vector B1 = new Vector(); // створення об'єкта за допомогою конструктора за замовчуванням
            Vector B2 = new Vector(6, 90); //створення об'єкта за допомогою конструктора з параметрами
            Vector B3 = new Vector(B2); //створення об'єкта за допомогою конструктора копіювання
            Console.WriteLine("Vectors:");
            Console.WriteLine("1. (" + B1.Get_length() + "," + B1.Get_angle() + ")");
            Console.WriteLine("2. (" + B2.Get_length() + "," + B2.Get_angle() + ")");
            Console.WriteLine("3. (" + B3.Get_length() + "," + B3.Get_angle() + ")");

            Vector b2 = new Vector(B2 / 2); //зменшення об'єкта вдвічі
            Console.WriteLine("Vectors after the division into 2 vector 2:");
            Console.WriteLine("1. (" + B1.Get_length() + "," + B1.Get_angle() + ")");
            Console.WriteLine("2. (" + b2.Get_length() + "," + b2.Get_angle() + ")");
            Console.WriteLine("3. (" + B3.Get_length() + "," + B3.Get_angle() + ")");

            Vector b3 = new Vector(B3.turn(45)); //поворот об'єкта на 45 градусів
            Console.WriteLine("Vectors after the turning 45 degrees vector 3 :");
            Console.WriteLine("1. (" + B1.Get_length() + "," + B1.Get_angle() + ")");
            Console.WriteLine("2. (" + b2.Get_length() + "," + b2.Get_angle() + ")");
            Console.WriteLine("3. (" + b3.Get_length() + "," + b3.Get_angle() + ")");
            
            B1 = b2 + b3; //складання двох об'єктів в один
            Console.WriteLine("Vectors after the  addition vector 2 and 3 and placing them into vector 1:");
            Console.WriteLine("1. (" + B1.Get_length() + "," + B1.Get_angle() + ")");
            Console.WriteLine("2. (" + b2.Get_length() + "," + b2.Get_angle() + ")");
            Console.WriteLine("3. (" + b3.Get_length() + "," + b3.Get_angle() + ")");
            Console.ReadKey();
        }
    }
}
