namespace MyLibr._3._1._11
{
    public class Costume : Clothes
    {
        public override string TextileType { get; set; }

        public string CostumeName { get; set; } //Название костюма

        public bool IsCostumeGood { get; set; } //Качество изделия

        public Costume(bool isIntegrityChecked, string manufacturerName, string textileType, string costumeName) : base(isIntegrityChecked, manufacturerName)
        {
            this.TextileType = textileType;
            this.ManufacturerName = manufacturerName;
            this.IsIntegrityChecked = isIntegrityChecked;
            this.CostumeName = costumeName;
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
            if (IsIntegrityChecked)
            {
                info += "Ткань цела" + "\n";
            }
            else
            {
                info += "Ткань разорвана" + "\n";
            }
            if ((IsIntegrityChecked) && (IsCostumeGood))
            {
                info += "Костюм хороший" + "\n";
            }
            else if ((IsIntegrityChecked) && (!IsCostumeGood))
            {
                info += "Костюм плохой или не прошел не был проверен" + "\n";
            }
            info += "Отзыв на одежду этой фирмы: " + YourReview ;
            return info;
        }

        public bool MarkAsGood() // отметить костюм как хороший
        {
            if (IsIntegrityChecked)// нельзя отметь костюм как хороший, если не проведена проверка на целостность ткани;
            {
                return IsCostumeGood = true;
            }
            else
            {
                return false;
            }
        }

        public bool MarkAsBad() // отметить костюм как плохой
        {
            if (IsIntegrityChecked)
            {
                return IsCostumeGood = false;
            }
            else
            {
                return false;
            }
        }

    }
}
