using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr
{
    public class Linear_Array : Array
    {

        public string Print()
        {
            string str = null;
            foreach (Element i in Arr)
            {
                str += Convert.ToString(i.Value) + " ";
            }
            return str;
        }

        public void Addition(int var)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i].Value += var;
            }
        }

        public void Difference(int var)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i].Value -= var;
            }
        }

        public void ProductOfNumbers(int var)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i].Value *= var;
            }
        }
    }
}
