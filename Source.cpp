// Melnytska Vitaliya IS-92

#include <iostream>
using namespace std;

class Vector {
private:
	int length_; //�������
	int angle_; //���
public:
	 Vector()//����������� �� �������������
	 {
		 length_ = 0;
		 angle_ = 0;
	} 
	 Vector(int length, int angle)  //���������� � �����������
		 {
			 length_ = length;
			 angle_ = angle;
	 }
	 Vector(const Vector& co) //����������� ���������
	 {
		 length_ = co.length_;
		 angle_ = co.angle_;
	 }
	 void copy(const Vector& co) {
		 this->length_ = co.length_;
		 this->angle_ = co.angle_;
	 }
	 
	 Vector turn( int angle ) { //����� �������� ������� �� ����-���� ���
		 Vector res;
		 int first;
		 first = Get_angle(); //��� �3
		  res.angle_ = angle + first; //��������� ��������
		  res.length_ = Get_length();
		 return res;

	 }
	 int Get_length() { //������ ��������� ����� �������
		 return length_;
	 }
	 int Get_angle() {
		 return angle_;
	 }
	 
	 Vector operator +(Vector obj) { // �������������� ��������� ���������
		 Vector res;
		 res.length_ = Get_length() + obj.length_;
		 res.angle_ = Get_angle() + obj.angle_;
		 return res;
	 }
	 Vector operator /(int a) { // �������������� ��������� ������
		 Vector res;
		 res.length_ = Get_length() / a;
		 res.angle_ = Get_angle();
		 return res;
	 }
	 //�������������� ��������� ������
	 friend ostream& operator <<(ostream& out, const Vector& d) {
		 out <<"("<< d.length_ <<" , "<< d.angle_<<")";
		 return out;
	 }
};

int main() {
	Vector B1; //  � ����������� �� ������������� 
	Vector B2(6,90); //��������� ����������� � ����������� � �����������
	Vector B3(B2);  // � ����������� ���������
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