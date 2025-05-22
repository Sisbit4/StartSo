using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgency
{
    public class ChildTourist : Tourist
    {
        public int Age { get; set; }
        public PersonGender Gender { get; set; }
        public VacationType VacationType { get; set; }

        public ChildTourist(string name, string surname, string tourCode, string tourStartDate, TimeSpan tourDuration, double tourPrice, PaymentType paymentMethod, int age, PersonGender gender, VacationType vacationType)
            : base(name, surname, tourCode, tourStartDate, tourDuration, tourPrice, paymentMethod)
        {
            Age = age;
            Gender = gender;
            VacationType = vacationType;
        }

        public override string[] GetInfo()
        {
            var info = new string[5];
            var touristInfo = base.GetInfo();

            info[0] = touristInfo[0];
            info[1] = touristInfo[1];
            info[2] = $"Возраст: {Age}";
            info[3] = $"Пол: {(Gender == PersonGender.Male ? "мужской" : "женский")}";
            info[4] = $"Тип отдыха: {(VacationType == VacationType.WithParents ? "с родителями" : "в детском оздоровительном лагере")}";

            return info;
        }
    }
}
