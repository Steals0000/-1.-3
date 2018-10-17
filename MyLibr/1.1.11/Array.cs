using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr
{
    public class Array
    { 
        public Element[] Arr { get; set; }

        public void Create (int length)
        {
            Element[] arr = new Element[length];
            Arr = arr;
        }

    }
}
