using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravelAgency;

namespace TravelAgency.UnitTests
{
    [TestFixture]
    public class TouristTests
    {
        [Test]
        public void ConstructorTest()
        {
            var tourist = new Tourist("Иван", "Иванов", "EUR-123", "15.07.2023",
                                    TimeSpan.FromDays(14), 50000, PaymentType.CreditCard);

            Assert.That(tourist.Name, Is.EqualTo("Иван"));
            Assert.That(tourist.Surname, Is.EqualTo("Иванов"));
            Assert.That(tourist.TourCode, Is.EqualTo("EUR-123"));
            Assert.That(tourist.TourStartDate, Is.EqualTo(new DateTime(2023, 7, 15)));
            Assert.That(tourist.TourDuration, Is.EqualTo(TimeSpan.FromDays(14)));
            Assert.That(tourist.TourPrice, Is.EqualTo(50000));
            Assert.That(tourist.PaymentMethod, Is.EqualTo(PaymentType.CreditCard));
        }

        [Test]
        public void GetInfoTest()
        {
            var tourist = new Tourist("Иван", "Иванов", "EUR-123", "15.07.2023",
                                    TimeSpan.FromDays(14), 50000, PaymentType.CreditCard);

            var info = tourist.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Иван Иванов"));
            Assert.That(info[1], Is.EqualTo("Тур: EUR-123. Дата начала: 15.07.2023. Продолжительность: 14 дней."));
            Assert.That(info[2], Is.EqualTo("Стоимость: 50000. Тип оплаты: банковской картой."));
        }
    }
}