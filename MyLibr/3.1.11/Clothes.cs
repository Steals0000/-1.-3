using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr._3._1._11
{
    public abstract class Clothes : ITextile
    {
        public abstract string TextileType { get; set; }

        public bool IsIntegrityChecked { get; set; }

        public string ManufacturerName { get; set; }

        public string YourReview { get; set; }

        public Clothes(string manufacturerName)
        {
            this.IsIntegrityChecked = false;
            this.ManufacturerName = manufacturerName;
            this.YourReview = "";
        }

        public abstract string DisplayInformation();

        public abstract bool CheckIntegrity();

        public void WriteReview(string text)
        {
            YourReview = text;
        }
    }
}
