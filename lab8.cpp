//Melnytska_Vitaliya_IS-92
#include <iostream>
#include <string>
using namespace std;

int littleABC(string);
int main() {
	string Abc = "Your time is limited, so don�t waste it living someone else�s life";
	int (*p)(string); //������ �� �-���
	p = littleABC; //��������� ������ �������
	cout << (*p)(Abc) << endl; //��������. �-���
	return 0;
}
//�-��� ����������� ����� ����
int littleABC(string Abc) {
	int count=0;
	for (int i = 0; i <= Abc.length(); i++) {
		 if (Abc[i] >= 'a' && Abc[i] <= 'z') //�������� �� ��� ������� � �����
			 count++;
	}
	return count;
}