using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel
{
    public class ForeignTourist : Tourist
    {
        public string PassportNumber { get; set; }
        public string RequiredVisas { get; set; }

        public ForeignTourist(string name, string surname, int duration, string code, PayType pay, string passportNumber, string requiredVisas)
            : base(name, surname, duration, code, pay)
        {
            PassportNumber = passportNumber;
            RequiredVisas = requiredVisas;
        }

        public override string GetInfo()
        {
            var baseInfo = base.GetInfo();
            return $"{baseInfo} Паспорт: {PassportNumber}. Визы: {RequiredVisas}.";
        }
    }

}
