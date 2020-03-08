#pragma once
#include <vector>
#include "String.h"

	class MyText {
	private:
		vector<MyString> s;
	public:
		void addRow(string b);
		void print();
		void replace(int index, string str);
		void clean();
		void delete_(int index);
		int count_str();
		void strings();

	};




