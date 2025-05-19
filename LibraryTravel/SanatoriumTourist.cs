using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel
{
    public class SanatoriumTourist : Tourist
    {
        public string MedicalPolicyNumber { get; set; }
        public string Diagnosis { get; set; }

        public SanatoriumTourist(string name, string surname, int duration, string code, PayType pay, string policy, string diagnosis)
            : base(name, surname, duration, code, pay)
        {
            MedicalPolicyNumber = policy;
            Diagnosis = diagnosis;
        }

        public override string GetInfo()
        {
            var baseInfo = base.GetInfo();
            return $"{baseInfo} Полис: {MedicalPolicyNumber}. Диагноз: {Diagnosis}.";
        }
    }
}

