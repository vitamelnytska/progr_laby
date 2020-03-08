using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class String
    {
        //кожний наш рядок:
        public char[] first;
        public String(string str)
        {
            //конвертуємо
            first = str.ToCharArray();
        }
    }

}
