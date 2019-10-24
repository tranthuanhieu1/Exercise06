using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack
    {
        private int [] Buffer;
        private int Top;
         public Stack(string value)
         {
             Buffer = new int[NotFiniteNumberException;
             Top = -1;
         }
        public void Put(int item)
        {
            Buffer[Top+1]= item;
            Top++;
        }
         public int Pop()
         {
             string number = Buffer[Top];
             Top--;
             return Buffer[Top];
         }
        public int Peek()
        {
            return Buffer[Top];
        }
        public int Count()
        {
           return Top;
        }
      
    }
}
