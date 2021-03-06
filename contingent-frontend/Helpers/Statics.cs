﻿using contingent_frontend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contingent_frontend.Helpers
{
    public static class Statics
    {
        public static BindingList<Specialty> Specialties = new BindingList<Specialty>
        {
            new Specialty { Code=null, Name="Абитуриенты", ShortName="" },
            new Specialty { Code="38.02.01", Name="Экономика и бухгалтерский учет", ShortName="БУ" },
            new Specialty { Code="09.02.03", Name="Программирование в компьютерных системах", ShortName="ПКС" },
            new Specialty { Code="38.02.04", Name="Коммерция (по отраслям)", ShortName="КПО" },
            new Specialty { Code="11.02.01", Name="Радиоаппаратостроение", ShortName="РАС" }
        };

        public static BindingList<Group> Groups = new BindingList<Group>
        {
            new Group { Specialty=Statics.Specialties[0] }
        };

        public static List<string> Genders = new List<string>
        {
            "Мужской", "Женский"
        };

        public static List<string> PassportTypes = new List<string>
        {
            "Свидительство о рождении", "Паспорт Украины", "Паспорт ЛНР", "Паспорт ДНР", "Паспорт РФ", "Другой"
        };

        public static List<string> StudyForms = new List<string>
        {
            "Очная", "Заочная", "Экстернат", "Индивидуальная"
        };

        public static List<string> Degrees = new List<string>
        {
            "Средняя общая", "Средняя профессиональная", "Высшая"
        };
    }
}
