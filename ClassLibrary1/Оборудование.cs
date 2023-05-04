using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Оборудование
    {
        public string Название { get; }
        public int Стоимость { get; }
        public DateTime ДатаПостановкиНаБаланс { get; }
        public Оборудование(string название, int стоимость, DateTime датаПостановкиНаБаланс)
        {
            Название = название;
            Стоимость = стоимость;
            ДатаПостановкиНаБаланс = датаПостановкиНаБаланс;
        }
    }
}
