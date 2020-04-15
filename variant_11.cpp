//Melnytska Vitaliya IS-92, ������-11
#define _USE_MATH_DEFINES
#include <iostream>
#include <string>
#include <math.h>
using namespace std;

class Rows { //������� ����
 //�������� �����
	
public:
	string a_;
	Rows(string a)  //����������� � ����������
	{
		this->a_ = a;
	}
	int count_l() //����� ���������� ������� �����
	{
		return a_.length();
	}
	void print() {
			cout << a_ ;
	}
};
//�������� ����
class Abc:public Rows{

public:
	//����������� � ����������
	Abc(string a) :Rows(a) {
	}
	//����� ����� ����� ������ �� 1 ������
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
	//����� ��������� ����� �����
	int Get_length()
	{
		return count_l();
	}
};
//������� ���� "Shapes"
class Shapes
{
public:
	virtual double Sqw()//��������� �-��� ���. �����
	{
		return 0;
	}
	virtual double Perymetr()//��������� �-��� ���. ���������
	{
		return 0;
	}


};
//�������� ���� "Square"
class Square :public Shapes
{
private: double AB;//�������� ������� �������
public: int xA, xB, yA, yB;//���������� ������
	
	 Square(int ax, int ay, int bx, int by)//����������� � �����������
	{
		xA = ax;
		xB = bx;
		yA = ay;
		yB = by;
		AB = 0;

	}
	 // �-��� ���. ������� ������� ��������
	 double pl()
	{
		AB = sqrt(pow((xA - xB), 2) + pow((yA - yB), 2));
		return AB;
	}
	 //��������� �-��� ���. �����
	 double Sqw()
	{

		return (pow(pl(), 2));
	}
	 //��������� �-��� ���. ���������
	double Perymetr()
	{
		return (4 * pl());
	}

};
//�������� ���� "Circle"
class Circle :public Shapes
{
	//����� ����
public: int _r;
	  //����������� � ����������
	 Circle(int r)
	{
		_r = r;

	}
	double Sqw()//��������� �-��� ���. �����
	{
		return((M_PI * _r * _r));
	}
	double Perymetr()//��������� �-��� ���. ���������
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