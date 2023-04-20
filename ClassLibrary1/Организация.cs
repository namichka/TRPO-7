using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Организация
    {
        public string Название { get; }
        public string ЮридическийАдрес { get; }
        public string ФактическийАдрес { get; }
        public Сотрудник Сотрудник { get; }

        public Организация(string название, string юридическийАдрес, string фактическийАдрес, Сотрудник сотрудник)
        {
            Название = название;
            ЮридическийАдрес = юридическийАдрес;
            ФактическийАдрес = фактическийАдрес;
            Сотрудник = сотрудник;
        }
    }
}
