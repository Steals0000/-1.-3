using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr._2._1._11
{
    public class PerformanceChild : Performance
    {
        public int YearOfWriting { get; set; }
        public int CurrentYear { get; set; }

        public PerformanceChild(int startViewersCount, int endViewersCount, string name, int yearOfWriting) : base(startViewersCount, endViewersCount, name)
        {
            YearOfWriting = yearOfWriting;
            CurrentYear = DateTime.Now.Year;
        }

        public override double GetQuality()
        {
            return base.GetQuality() * ((double)CurrentYear - (double)YearOfWriting + 1.0);
        }
    }
}
