using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgency
{
    public class SanatoriumTourist : Tourist
    {
        public string MedicalPolicyNumber { get; set; }
        public string Diagnosis { get; set; }

        public SanatoriumTourist(string name, string surname, string tourCode, string tourStartDate, TimeSpan tourDuration, double tourPrice, PaymentType paymentMethod, string medicalPolicyNumber, string diagnosis)
            : base(name, surname, tourCode, tourStartDate, tourDuration, tourPrice, paymentMethod)
        {
            MedicalPolicyNumber = medicalPolicyNumber;
            Diagnosis = diagnosis;
        }

        public override string[] GetInfo()
        {
            var info = new string[4];
            var touristInfo = base.GetInfo();

            info[0] = touristInfo[0];
            info[1] = touristInfo[1];
            info[2] = $"Мед. полис: {MedicalPolicyNumber}";
            info[3] = $"Диагноз: {Diagnosis}";

            return info;
        }
    }
}
