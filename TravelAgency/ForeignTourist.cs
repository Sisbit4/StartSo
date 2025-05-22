using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgency
{
    public class ForeignTourist : Tourist
    {
        public string PassportNumber { get; set; }
        public string RequiredVisas { get; set; }

        public ForeignTourist(string name, string surname, string tourCode, string tourStartDate, TimeSpan tourDuration, double tourPrice, PaymentType paymentMethod, string passportNumber, string requiredVisas)
            : base(name, surname, tourCode, tourStartDate, tourDuration, tourPrice, paymentMethod)
        {
            PassportNumber = passportNumber;
            RequiredVisas = requiredVisas;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            var touristInfo = base.GetInfo();

            info[0] = touristInfo[0];
            info[1] = touristInfo[1];
            info[2] = $"Загранпаспорт: {PassportNumber}";
            info[3] = $"Необходимые визы: {RequiredVisas}";

            return info;
        }
    }
}
