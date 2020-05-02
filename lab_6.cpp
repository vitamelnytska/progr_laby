#include <iostream>
#include <math.h>
using namespace std;


class Expression
{
private: double a_, b_, c_; //����� ���
public: Expression() { a_ = 0; b_ = 0; c_ = 0;}  //����������� �� �������������
	  Expression(double a, double b, double c) { a_ = a; b_ = b; c_ = c;} //����������� � �����������
	  void Answer() 
	  {					//�������� �� ����� ������
			  try
			  {
				  if ((a_ * b_ + 2) <= 0)
					  throw "logarithmic expression must be >=1 (a_ * b_ + 2)";
				  else if (c_ == 0)
					  throw "Cannot divide by 0 (c=0)";
				  else if ((41 - b_ / c_ + 1) == 0)
					  throw "Cannot divide by 0 (41 - b / c + 1 = 0)";
				  else print();
			  }
			  catch (const char* exeption) { //������ ������� ������
				  cout << "Error " << exeption << endl;
			  }
	  }
	  double calculate()//����������� ������
	  {
		  return (log10(a_ * b_ + 2) * c_ / (41 - b_ / c_ + 1));
	  }
	  void print() { //��������� ����������
		  cout << calculate() << endl;
	  }
	  void print_abc() { //��������� ������� �����
		  cout << "a=" <<a_<< " b=" <<b_<< " c="<<c_<<endl;
	  }
};

int main() {
	Expression* arr = new Expression[4]; //����� ��'���� ������� �����
	arr[0] = Expression(1, 2, 3);
	arr[1] = Expression(1, 2, 0);
	arr[2] = Expression(1, 42, 1);
	arr[3] = Expression(1, -2, 1);
	cout << "\n***************************************************" << endl;
	for (int i = 0; i < 4; i++) {
		arr[i].print_abc();
		cout << "\tExpression log10(a * b + 2) * c / (41 - b / c + 1) = ";
		arr[i].Answer();
	}
	cout << "\n***************************************************" << endl;
	return 0;
}