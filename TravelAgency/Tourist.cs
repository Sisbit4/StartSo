using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Tourist : IComparable<Tourist>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string TourCode;
        public DateTime TourStartDate { get; set; }
        public TimeSpan TourDuration { get; set; }
        public double TourPrice { get; set; }
        public PaymentType PaymentMethod { get; set; } 

        public DateTime TourEndDate => TourStartDate.Add(TourDuration);

        public Tourist(string name, string surname, string tourCode, string tourStartDate, TimeSpan tourDuration, double tourPrice, PaymentType paymentMethod)
        {
            Name = name;
            Surname = surname;
            TourCode = tourCode;

            if (!DateTime.TryParse(tourStartDate, out var startDate))
                throw new ArgumentException("Неверный формат даты начала тура");

            TourStartDate = startDate;
            TourDuration = tourDuration;
            TourPrice = tourPrice;
            PaymentMethod = paymentMethod;
        }

        public int CompareTo(Tourist other)
        {
            if (other == null)
                return 1;

            int surnameCompare = string.Compare(Surname, other.Surname,
                                              StringComparison.CurrentCultureIgnoreCase);
            if (surnameCompare != 0)
                return surnameCompare;

            return string.Compare(Name, other.Name,
                                 StringComparison.CurrentCultureIgnoreCase);
        }

        public virtual string[] GetInfo()
        {
            var info = new string[3];
            info[0] = $"{Name} {Surname}";
            info[1] = $"Тур: {TourCode}. Дата начала: {TourStartDate:d}. Продолжительность: {TourDuration.Days} дней.";

            string paymentMethod;
            switch (PaymentMethod)
            {
                case PaymentType.Cash: paymentMethod = "наличные"; break;
                case PaymentType.CreditCard: paymentMethod = "банковской картой"; break;
                case PaymentType.BankTransfer: paymentMethod = "перечисление по счету"; break;
                default: paymentMethod = "неизвестно"; break;
            }

            info[2] = $"Стоимость: {TourPrice}. Тип оплаты: {paymentMethod}.";
            return info;
        }
    }
}
