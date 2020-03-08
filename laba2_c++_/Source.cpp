#include "MyText.h"
using namespace std;


int main() {
	MyText a = MyText();
	a.addRow("123 HELLO");
	a.addRow("World 45");
	a.addRow("hello 67");
	a.addRow("bye 89");
	a.print();
	int b = a.count_str();
	cout << "\n\tNumber of rows:" << b << endl;
	//a.strings();

	cout << "------------------------------\n";
	cout << "\tReplacing rows:" << endl;
	a.replace(1, "replaced");
	a.print();
	cout << "\tDelete a row:\n";
	a.delete_(1);
	a.print();
	cout << "\t Cleaning the text:\n";
	a.clean();
	a.print();


}