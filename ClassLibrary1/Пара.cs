using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Пара
    {
        public string НачалоПары { get; }
        public string КонецПары { get; }
        public string НачалоПерерыва { get; }
        public string КонецПерерыва { get; }
        public Смена Смена { get; }
        public Пара(string началоПары, string конецПары, string началоПерерыва, string конецПерерыва, Смена смена)
        {
            НачалоПары = началоПары;
            КонецПары = конецПары;
            НачалоПерерыва = началоПерерыва;
            КонецПерерыва = конецПерерыва;
            Смена = смена;
        }
    }
}
