using System;
using System.Collections.Generic;
using System.Text;

namespace laba_3
{
    class Array
    {
        private int[] array;
        private int _start;
        public bool error;
        private int _length;
        
        
        public Array(int start, int length)
        {
            _start = start;
            array = new int[length];
            _length = length;
        }
        public int this[int index]
        {
            set
            {
                index -= _start;
                if ((index >= 0) && (index < _length))
                {
                    array[index] = value;
                    error = false;

                }
                else error = true;
            }
            get
            {
                index -= _start;
                if ((index >= 0) && (index < _length))
                {
                    error = false;
                    return array[index];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            
            
        }
        public int Length_array
        {
            get{
                return _length;
            }
            
        }
        
    }
    
}
