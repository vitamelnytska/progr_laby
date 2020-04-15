//Melnytska Vitaliya IS-92, Варіант-11

using System;


namespace lab_5_cs
{
    class Rows//базовий клас
    {
        public string a_ ; //значення рядка

        public Rows(string a)  //конструктор з параметром
        {
            this.a_ = a;
        }
        public int count_l() //метод обчислення довжини рядка
        {
            return a_.Length;
        }
        public void print()
        {
            
                Console.WriteLine(a_);
            
        }
    }
    class Abc : Rows {
        //конструктор з праметром
        public Abc(string a) : base(a){ }
        //метод зсуву рядка на 1 символ право
	    public void shift(int n)
        {
            string a="", b="", ab;
            for (int j = 0; j < n; j++)
            {
                a += a_[a_.Length - j - 1];
            }
            for (int i = 0; i < a_.Length - n; i++)
            {
                b += a_[i];
            }
            ab = a + b;
            this.a_ = ab;

        }
      
        //метод отримання даних
        public int Get_length() 
        {
            return count_l();
        }


    }
    //базовий клас "Shapes"
    class Shapes
    {
        virtual public double Sqw() //базовий клас "Shapes"
        {
            return 0;
        }
        virtual public double Perymetr() //віртуальна ф-ція обч. периметру
        {
            return 0;
        }
        

    }
    //похідний клас "Square"
    class Square : Shapes
    {   //координати вершин
        public int xA, xB, yA, yB;
        private double AB; //значення довжини сторони
        public Square(int ax, int ay, int bx, int by) //конструктор з параметрами
        {
            xA = ax; 
            xB = bx; 
            yA = ay; 
            yB = by;

        }
        // ф-ція обч. довжини сторони квадрату
        public double pl()
        {
            AB = Math.Sqrt(Convert.ToInt32(Math.Pow((xB - xA ), 2)) + Convert.ToInt32(Math.Pow((yB - yA), 2)));
            return (AB);
        }
        //віртуальна ф-ція обч. площі
        public override double Sqw()
        {
            
            return (Convert.ToInt32(Math.Pow(pl(),2)));
        }
        //віртуальна ф-ція обч. периметру
        public override double Perymetr()
        {
            return (4 * pl());
        }
        
    }
    //похідний клас "Circle"
    class Circle : Shapes
    {   //радіус кола
        public int _r;
        //конструктор з параметром
        public Circle(int r)
        {
            _r = r;

        }

        //віртуальна ф-ція обч. площі
        override public double Sqw()
        {
            return((Math.PI*_r*_r));
        }
        //віртуальна ф-ція обч. периметру
        override public double Perymetr()
        {
            return ((Math.PI * _r * 2));
        }
    }
class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******************************\nTask 1\n");
            Abc str = new Abc("abcdefgh");
            Console.WriteLine("String: ");
            str.print() ;
            Console.WriteLine("String after the moving elements: ");
            str.shift(1);
            str.print();
            Console.WriteLine("Length of string: "+ str.Get_length());
            Console.WriteLine("\n******************************\t\n\nTask 2");
            
            Shapes [] fig = new Shapes[2];
            Square kvadrat = new Square(2,0,2,2);
            fig[0] = kvadrat;
            fig[0].Sqw();
            fig[0].Perymetr();
            Circle kolo = new Circle(2);
            fig[1] = kolo;
            fig[1].Sqw();
            fig[1].Perymetr();
            foreach(Shapes element in fig)
            {
                Console.WriteLine("----------");
                Console.WriteLine("Square is {0}", element.Sqw());
                Console.WriteLine("Perymetr is {0}", element.Perymetr());

            }
        }
    }
}
