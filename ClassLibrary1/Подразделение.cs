using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{


    public class Подразделение
    {
        public string Название { get; }
        public Сотрудник Руководитель { get; }
        public Организация Организация { get; }

        public Подразделение(string название, Сотрудник сотрудник, Организация организация)
        {
            Название = название;
            Руководитель = сотрудник;
            Организация = организация;
        }
        public Подразделение(string название, Организация организация)
        {
            Название = название;
            Организация = организация;
        }
    }

}
