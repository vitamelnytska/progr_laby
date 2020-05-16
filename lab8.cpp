//Melnytska_Vitaliya_IS-92
#include <iostream>
#include <string>
using namespace std;

int littleABC(string);
int main() {
	string Abc = "Your time is limited, so don’t waste it living someone else’s life";
	int (*p)(string); //ссилка на ф-цію
	p = littleABC; //присвоєння ссилці функції
	cout << (*p)(Abc) << endl; //використ. ф-ції
	return 0;
}
//ф-ція підрахування малих літер
int littleABC(string Abc) {
	int count=0;
	for (int i = 0; i <= Abc.length(); i++) {
		 if (Abc[i] >= 'a' && Abc[i] <= 'z') //перевірка на малі символи в рядку
			 count++;
	}
	return count;
}