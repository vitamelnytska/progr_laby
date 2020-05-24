using System;
using System.Collections.Generic;
using System.Text;

namespace lab_7_cs
{
    class Node
    {
        public float num_ { get; set; } //дані вузла
        public Node Next { set; get; }  //посилання на наступний вузол
        public Node(float num) //конструктор вузла
        {
            num_ = num;
        }

    }
}
