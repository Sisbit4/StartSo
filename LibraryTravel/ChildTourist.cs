using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel
{
    public class ChildTourist : Tourist
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public VacationType Vacation { get; set; }

        public ChildTourist(string name, string surname, int duration, string code, PayType pay, int age, string gender, VacationType vacation)
            : base(name, surname, duration, code, pay)
        {
            Age = age;
            Gender = gender;
            Vacation = vacation;
        }

        public override string GetInfo()
        {
            string vacation; if (Vacation == VacationType.WithParents)
                vacation = "с родителями";
            else
                vacation = "в детском оздоровительном лагере";
            return base.GetInfo() + $", Возраст: {Age}, Пол: {Gender}, Отдых: {vacation}";
        }
    }
}
