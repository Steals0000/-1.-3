namespace MyLibr._3._1._11
{
    public class Costume : Clothes
    {
        public override string TextileType { get; set; }

        public string CostumeName { get; set; }

        public bool IsCostumeGood { get; set; }

        public bool CostumeIntegrity { get; set; }

        public Costume(string manufacturerName, string textileType, string costumeName, bool costumeIntegrity) : base(manufacturerName)
        {
            this.TextileType = textileType;
            this.ManufacturerName = manufacturerName;
            this.CostumeName = costumeName;
            this.CostumeIntegrity = costumeIntegrity;
        }

        public override bool CheckIntegrity()
        {
            return IsIntegrityChecked = true;
        }

        public override string DisplayInformation()
        {
            string info = "";
            info += "Тип ткани: " + TextileType + "\n";
            info += "Название костюма: " + CostumeName + "\n";
            info += "Производитель: " + ManufacturerName + "\n";
            if (CostumeIntegrity)
            {
                info += "Ткань цела" + "\n";
            }
            else
            {
                info += "Ткань разорвана" + "\n";
            }
            if (IsIntegrityChecked)
            {
                info += "Целостность проверена" + "\n";
            }
            else
            {
                info += "Целостность не проверена" + "\n";
            }
            if ((CostumeIntegrity) && (IsCostumeGood))
            {
                info += "Костюм отмечен как хороший" + "\n";
            }
            else if (!IsCostumeGood)
            {
                info += "Костюм отмечен как плохой" + "\n";
            }
            info += "Отзыв на одежду этой фирмы: " + YourReview;
            return info;
        }

        public bool MarkAsGood()
        {
            if (IsIntegrityChecked)
            {
                return IsCostumeGood = true;
            }
            else
            {
                return false;
            }
        }

        public void MarkAsBad()
        {
            IsCostumeGood = false;
        }

    }
}
