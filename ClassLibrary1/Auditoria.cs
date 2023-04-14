﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auditoria
    {
        public string Name { get; }
        public Employee Employee { get; }
        public string NumberMest { get; }
        public string NumberOkon { get; }
        public Oborydovanie Oborydovanie { get; }

        public Auditoria(string name, Employee employee, string numbermest, string numberokon, Oborydovanie oborydovanie)
        {
            Name = name;
            Employee = employee;
            NumberMest = numbermest;
            NumberOkon = numberokon;
            Oborydovanie = oborydovanie;
        }
    }
}
