using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LibraryTravel;

namespace UnitTestsLab
{
    [TestFixture]
    public class TouristTests
    {
        [Test]
        public void ConstructorTest()
        {
            var tourist = CreateTestTourist();

            Assert.That(tourist.Name, Is.EqualTo("Anna"));
            Assert.That(tourist.Surname, Is.EqualTo("Ivanova"));
            Assert.That(tourist.TourCode, Is.EqualTo("EKB2025"));
            Assert.That(tourist.TourDuration, Is.EqualTo(7));
            Assert.That(tourist.PayType, Is.EqualTo(PayType.CreditCard));
        }

        [Test]
        public void GetInfoTest()
        {
            var tourist = CreateTestTourist();
            tourist.Cost = 15000;
            tourist.StartDate = new DateTime(2025, 6, 1);

            var info = tourist.GetInfo();

            string expected = "Имя: Anna Ivanova, Код тура: EKB2025, Дата начала: 01.06.2025, Продолжительность: 7 дней, Дата окончания: 08.06.2025, Стоимость: 15000, Тип оплаты: банковская карта";
            Assert.That(info, Is.EqualTo(expected));
        }

        private Tourist CreateTestTourist()
        {
            return new Tourist("Anna", "Ivanova", 7, "EKB2025", PayType.CreditCard)
            {
                StartDate = new DateTime(2025, 6, 1),
                Cost = 15000
            };
        }
    }
}

