// Melnytska Vitaliya IS-92

#include <iostream>
using namespace std;

class Vector {
private:
	int length_; //довжина
	int angle_; //кут
public:
	 Vector()//конструктор за замовчуванням
	 {
		 length_ = 0;
		 angle_ = 0;
	} 
	 Vector(int length, int angle)  //коструктор з параметрами
		 {
			 length_ = length;
			 angle_ = angle;
	 }
	 Vector(const Vector& co) //конструктор копіювання
	 {
		 length_ = co.length_;
		 angle_ = co.angle_;
	 }
	 void copy(const Vector& co) {
		 this->length_ = co.length_;
		 this->angle_ = co.angle_;
	 }
	 
	 Vector turn( int angle ) { //метод повороту вектору на будь-який кут
		 Vector res;
		 int first;
		 first = Get_angle(); //дані В3
		  res.angle_ = angle + first; //результат повороту
		  res.length_ = Get_length();
		 return res;

	 }
	 int Get_length() { //методи отримання даних вектора
		 return length_;
	 }
	 int Get_angle() {
		 return angle_;
	 }
	 
	 Vector operator +(Vector obj) { // перевантаження оператора додавання
		 Vector res;
		 res.length_ = Get_length() + obj.length_;
		 res.angle_ = Get_angle() + obj.angle_;
		 return res;
	 }
	 Vector operator /(int a) { // перевантаження оператора ділення
		 Vector res;
		 res.length_ = Get_length() / a;
		 res.angle_ = Get_angle();
		 return res;
	 }
	 //перевантаження оператора виводу
	 friend ostream& operator <<(ostream& out, const Vector& d) {
		 out <<"("<< d.length_ <<" , "<< d.angle_<<")";
		 return out;
	 }
};

int main() {
	Vector B1; //  у конструктор за замовчуванням 
	Vector B2(6,90); //параметри передаються у конструктор з параметрами
	Vector B3(B2);  // у конструктор копіювання
	cout << "Vectors:" << endl;
	cout <<"1. "<< B1 << endl;
	cout << "2. " << B2 << endl;
	cout << "3. " << B3 << endl;
	B2.copy(B2.operator/ (2));
	cout << "Vectors after the division into 2 vector 2:" << endl;
	cout << "1. " << B1 << endl;
	cout << "2. " << B2 << endl;
	cout << "3. " << B3 << endl;
	B3.copy( B3.turn( 45)) ;
	cout << "Vectors after the turning 45 degrees vector 3 :" << endl;
	cout << "1. " << B1 << endl;
	cout << "2. " << B2 << endl;
	cout << "3. " << B3<< endl;
	B1 = B2 + B3;
	cout << "Vectors after the  addition vector 2 and 3 and placing them into vector 1:" << endl;
	cout << "1. " << B1 << endl;
	cout << "2. " << B2 << endl;
	cout << "3. " << B3 << endl;
	return 0;
}