//Melnytska Vitaliya IS-92, Варіант-11
#define _USE_MATH_DEFINES
#include <iostream>
#include <string>
#include <math.h>
using namespace std;

class Rows { //базовий клас
 //значення рядка
	
public:
	string a_;
	Rows(string a)  //конструктор з параметром
	{
		this->a_ = a;
	}
	int count_l() //метод обчислення довжини рядка
	{
		return a_.length();
	}
	void print() {
			cout << a_ ;
	}
};
//похідний клас
class Abc:public Rows{

public:
	//конструктор з параметром
	Abc(string a) :Rows(a) {
	}
	//метод зсуву рядка вправо на 1 симовл
	void shift(int n) {
		string a, b,ab;
		for (int j = 0; j < n; j++)
		{
			a += a_[a_.length() - j - 1];
		}
		for (int i = 0; i <a_.length()-n; i++)
		{
			b += a_[i];
		}
		ab = a + b;
		this->a_ = ab;
	}
	//метод отримання даних рядка
	int Get_length()
	{
		return count_l();
	}
};
//базовий клас "Shapes"
class Shapes
{
public:
	virtual double Sqw()//віртуальна ф-ція обч. площі
	{
		return 0;
	}
	virtual double Perymetr()//віртуальна ф-ція обч. периметру
	{
		return 0;
	}


};
//похідний клас "Square"
class Square :public Shapes
{
private: double AB;//значення довжини сторони
public: int xA, xB, yA, yB;//координати вершин
	
	 Square(int ax, int ay, int bx, int by)//конструктор з параметрами
	{
		xA = ax;
		xB = bx;
		yA = ay;
		yB = by;
		AB = 0;

	}
	 // ф-ція обч. довжини сторони квадрату
	 double pl()
	{
		AB = sqrt(pow((xA - xB), 2) + pow((yA - yB), 2));
		return AB;
	}
	 //віртуальна ф-ція обч. площі
	 double Sqw()
	{

		return (pow(pl(), 2));
	}
	 //віртуальна ф-ція обч. периметру
	double Perymetr()
	{
		return (4 * pl());
	}

};
//похідний клас "Circle"
class Circle :public Shapes
{
	//радіус кола
public: int _r;
	  //конструктор з параметром
	 Circle(int r)
	{
		_r = r;

	}
	double Sqw()//віртуальна ф-ція обч. площі
	{
		return((M_PI * _r * _r));
	}
	double Perymetr()//віртуальна ф-ція обч. периметру
	{
		return ((M_PI * _r * 2));
	}
};

int main() {
	cout << "******************************\nTask 1\n";
	Abc str = Abc("abcdefgh");
	cout << "String: ";
	str.print();
	cout << endl;
	cout << "String after the moving elements: ";
	str.shift(1); 
	str.print();
	cout << endl;
	cout<<"Length of string: " <<str.Get_length()<<endl;
	
	cout<<"\n******************************\t\n\nTask 2"<<endl;
	
	Shapes* fig = new Shapes();
	fig = new Square(2,0,2,2);
	cout << "\n\tKvadrat:\n";
	cout << "Square is " << fig->Sqw() << endl;
	cout << "Perymetr is " << fig->Perymetr() << endl;
	int r = 2;
	fig = new Circle(r);
	cout << "\n\tCircle: radius = " << r << endl;
	cout << "Square is " << fig->Sqw() << endl;
	cout << "Perymetr is " << fig->Perymetr() << endl;
	return 0;
	
}