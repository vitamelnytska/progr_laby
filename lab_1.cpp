#include <iostream>

using namespace std;

int increment(int*);
int greater_than(int, int);

int main() {
	int a, x, y;
	cout << "Melnytska Vitaliya IS-92\n";
	cout << "Enter a value: \n";
	cin >> a;
	cout << increment(&a) << endl;
	cout << "Enter two numbers\n";
	cin >> x;
	cin >> y;
	cout << greater_than(x, y) << endl;
	return 0;
}

//функція +1
int increment(int* x) { 
	int x0 = *x;
	for (int i = 0; i < sizeof(*x) * 4; i++) {
		*x = *x ^ (1 << i);
		if ((x0 & (1 << i)) == 0) break; //коли операція або == 0, виходимо з циклу
	}
	return *x;
}

int greater_than(int x, int y) {
	if ((x ^ y) == 0) { //якщо числа рівні, то повертаємо -1
		return -1;
	}
	else if ((((x - y) >> 31)) == 0) { //якщо перше число більше за друге, то повертаємо 1
		return 1;
	}
	else return 0;  //якщо 1 число не більше за друге, то повертаємо 0
}