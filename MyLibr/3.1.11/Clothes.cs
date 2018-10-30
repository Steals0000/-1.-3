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

        public string ManufacturerName { get; set; } //Название производителя

        public string YourReview { get; set; } //Ваш отзыв на эту одежду

        public Clothes(bool isIntegrityChecked, string manufacturerName)
        {
            this.IsIntegrityChecked = isIntegrityChecked;
            this.ManufacturerName = manufacturerName;
            this.YourReview = "";
        }

        public abstract string DisplayInformation();// Вывести информацию о ткани

        public abstract bool CheckIntegrity();// Проверить целостность ткани

        public void WriteAReview(string text) // оставить отзыв;
        {
            YourReview = text;
        }
    }
}
