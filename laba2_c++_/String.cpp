#include "String.h"

MyString::MyString(string r) {
	first = r;
}

ostream& operator <<(ostream& os, const MyString& str) {
	os << str.first;
	return os;
}
