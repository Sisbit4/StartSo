using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel
{
    public class Tourist
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string TourCode; public DateTime StartDate { get; set; }
        public int TourDuration { get; set; }
        public double Cost { get; set; }
        public PayType PayType { get; set; }
        public DateTime EndDate => StartDate.AddDays(TourDuration);
        public Tourist(string name, string surname, int duration, string code, PayType pay)
        {
            Name = name; Surname = surname;
            TourDuration = duration; TourCode = code;
            PayType = pay;
        }
        public virtual string GetInfo()
        {
            string pay; if (PayType == PayType.Cash)
                pay = "наличные";
            else if (PayType == PayType.CreditCard)
                pay = "банковская карта";
            else
                pay = "перечисление по счету";
            return $"Имя: {Name} {Surname}, Код тура: {TourCode}, Дата начала: {StartDate:d}, Продолжительность: {TourDuration} дней, Дата окончания: {EndDate:d}, Стоимость: {Cost}, Тип оплаты: {pay}";
        }
    }
}
