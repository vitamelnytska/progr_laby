//Мельницька Віталія ІС-92
#include <iostream>
using namespace std;
//що в собі містить вузол:
struct Node
{

	float num; //наше значення
	
	Node *next; //ссилка на наступний вузол
};
typedef Node* pNode; //вказівник на структуру
pNode Head = NULL; //ссилка на наступний елемент
pNode THead = NULL; //ссилка на наступний елемент іншого списку
//створення вузла
pNode CreateNode(float newNumber) {
	pNode newNode = new Node;
	newNode->num = newNumber;
	
	newNode->next = NULL;
	return newNode; //повертає адресу створеного вузла
}
//включення до початку
void AddFirst(pNode & Head, pNode newNode) {
	newNode->next = Head;
	Head = newNode;
}
//пошук середнього значення в списку
float Average(pNode& Head) {
	pNode q = Head;
	float average = 0;
	float sum = 0;
	int count = 0;
	//поки вузол не дорівнює нулю
	while (q) {
		sum += q->num;
		count++;
		q = q->next;
	}
	average = sum / count;
	return average; //повертаємо шукане середнє значення
}
// рахує кількість елем. більших за середнє значення
int Count(pNode& Head, float a) {
	pNode q = Head;
	int count = 0;
	while (q) {
		if (q->num > a) {
			count++;
		}
		q = q->next;
	}
	return count;
}
// ф-ція видалення вузлів
void DeleteNode(pNode& Head, pNode p) {
	pNode q = Head;
	if (Head == p)
		Head = p->next;
	else {
		while (q && q->next != p) {
			q = q->next;
			if (q == NULL) return;
			q->next = p->next;
		}
		delete p;
	}
}
// видалення вузлів з від'ємними значеннями
void DeleteNegative(pNode& Head) {
	pNode q = Head;
	while (q) {
		if (q->num < 0)
			DeleteNode(Head, q);
		q = q->next;
	}
} 
//виведення списку
void print(pNode &Head) {
	cout << "List:" << endl;
	pNode q = Head;
	while (q) {
		cout << q->num<<" ";
		q = q->next;
	}
	cout << endl;
}
int main()
{
	
	float a[] = { 3.25,4.25,6.25,7.25, -9.5,-1.5 };
	float b[] = { 1.2,1.2,-2.2,-2.2, -2.5,-2.5 };
	for (int i = 0; i <= 5; i++) {
		pNode f = CreateNode(a[i]); //створюємо список один
		AddFirst(Head, f);

	}
	float aver = Average(Head); 
	print(Head);
	cout <<endl<< "average: "<<aver << endl;
	cout <<"Amount: "<< Count(Head,aver) << endl;
	DeleteNegative(Head); //видаляємо вузли
	print(Head);
	for (int i = 0; i <= 5; i++) { //створємо список другий
		pNode g = CreateNode(b[i]); 
		AddFirst(THead, g); 

	}
	//шукаємо сер. значення в другому списку
	float Taver = Average(THead);
	print(THead);
	cout << endl << "average: " << Average(THead) << endl;
	cout << "Amount: " << Count(THead, Taver) << endl;
	DeleteNegative(THead);
	print(THead);
	return 0;

	

}