using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_cs
{
    class List
    {
        Node Head; 
        public Node CreateNode(float num) //створення нового вузла
        {
            Node newNode = new Node(num); //передаємо значення в вузол
            newNode.Next = null; //залишаємо ссилку на наступний
            return newNode; //повертаємо ссилку даного вузла
        }
        public void AddFirst(Node newNode) //додаємо вузол до початку списку
        {
            newNode.Next = Head; //сслику вузла - колишній початковий вузол
            Head = newNode; //початок тепер даний вузол
        }
        public float Average() //пошук середнього значення 
        {
            Node q = Head;
            float average = 0;
            float sum = 0;
            int count = 0;
            while (q!=null)
            {
                sum += q.num_;
                count++;
                q = q.Next;
            }
            average = sum / count;
            return average;
        }
        public int Count( float a) //рахує кількість елементів вузла більших за середнє значення
        {
            Node q = Head;
            int count = 0;
            while (q!=null)
            {
                if (q.num_ > a)
                {
                    count++;
                }
                q = q.Next;
            }
            return count;
        }
        void DeleteNode(float num) //видаляє вузок
        {
            Node q = Head;
            Node p = null;
            while (q != null) //пребір всіх елементів
            {
                if (q.num_.Equals(num)) //якщо знайшли елемент, що задовольняє умови видалення
                {

                    if (p != null) //якщо вузол не останній
                    {
                        p.Next = q.Next; //встановлюємо вказівник попереднього елемента на поточний
                       
                    }
                    else
                    {
                        Head = Head.Next; //ставимо вказівник на головний елемент

                    }
                   
                }
                p = q; //переходимо до наступного елемента
                q = p.Next;
            }

        }
        public void DeleteNegative() //видаляє вузли з негативними елементами
        {
            Node q = Head;
            while (q!=null)
            {
                if (q.num_ < 0)
                    DeleteNode(q.num_);
                q = q.Next;
            }
        }
       public void print() //виведення списку
        {
            Console.WriteLine("List:");
            Node q = Head;
            while (q!=null)
            {
                Console.WriteLine( q.num_);
                q = q.Next;
            }
            Console.WriteLine("");
        }


    }
}
