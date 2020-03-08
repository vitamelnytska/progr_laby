#include "MyText.h"
void MyText:: addRow(string b) {
		s.push_back(string(b));

	}

void MyText:: print()
	{
		cout << "------------------------------" << endl;
		for (int i = 0; i < s.size(); i++)
		{

			cout << i + 1 << ". " << MyString(s[i]) << endl;
		}
		cout << "------------------------------\n";
}
	void MyText::replace(int index, string str) {
		s[index - 1] = str;
	}
	void MyText::clean()
	{

		s.clear();
	}
	void MyText::delete_(int index)
	{
		s.erase(s.begin() + index);
	}

	int MyText::count_str()
	{
		int count = 0;
		for (int i = 0; i < s.size(); i++)
			count++;
		return count;

	}

	void MyText::strings()
	{
		cout << "------------------------------" << endl;
		cout << "\tMy text:" << endl;
		double val;
		string ab;
		string rer;
		for (int i = 0; i < s.size(); i++)
		{
	//		rer.append((s[i]));

		}
		for (int j = 0; j < rer.size(); j++)
		{


			if (isdigit(rer[j]))
			{
				ab += rer[j];
			}

		}




		cout << rer << endl;
		cout << "\nnumbers: " + ab << endl;
	}
