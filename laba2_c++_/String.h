#pragma once
#include <iostream>
using namespace std;

class MyString {
private:
	string first;
	
public:
	MyString(string r);
	
	friend ostream& operator <<(ostream& os, const MyString& str);

};


