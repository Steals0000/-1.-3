using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibr._3._1._11
{
    public interface ITextile
    {
        string TextileType { get; set; }// Тип ткани

        string DisplayInformation();// Вывести информацию о ткани

        bool CheckIntegrity();// Проверить целостность
    }
}
