using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr._2._1._11
{
    public class Performance
    {
        private int StartViewersCount { get; set; }
        public int EndViewersCount { get; set; }
        public string Name { get; set; }

        public Performance(int startViewersCount, int endViewersCount, string name)
        {
            StartViewersCount = startViewersCount;
            EndViewersCount = endViewersCount;
            Name = name;
        }

        public virtual double GetQuality()
        {
            if (StartViewersCount == 0)
            {
                return (double)EndViewersCount;
            }
            else
            {
                return ((double)EndViewersCount - (double)StartViewersCount) / (double)StartViewersCount;
            }
        }
    }
}
