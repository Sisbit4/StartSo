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
    public class TourTests
    {
        private Tour testTour;
        private Tourist[] testTourists;

        [SetUp]
        public void Setup()
        {
            testTourists = new Tourist[]
            {
                new Tourist("Иван", "Иванов", "EUR-123", "15.07.2023",
                          TimeSpan.FromDays(14), 50000, PaymentType.CreditCard),
                new Tourist("Петр", "Петров", "EUR-123", "15.07.2023",
                          TimeSpan.FromDays(14), 50000, PaymentType.Cash),
                new Tourist("Мария", "Сидорова", "ASIA-456", "01.08.2023",
                          TimeSpan.FromDays(21), 75000, PaymentType.BankTransfer)
            };

            testTour = new Tour("Европейский тур", "EUR-123", testTourists);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(testTour.Title, Is.EqualTo("Европейский тур"));
            Assert.That(testTour.TourCode, Is.EqualTo("EUR-123"));
        }

        [Test]
        public void ConstructorFilterTest()
        {
            Assert.That(testTour.TouristCount, Is.EqualTo(2));
            Assert.That(testTour.Any(t => t.Surname == "Иванов"), Is.True);
            Assert.That(testTour.Any(t => t.Surname == "Петров"), Is.True);
            Assert.That(testTour.Any(t => t.Surname == "Сидорова"), Is.False);
        }

        [Test]
        public void Constructor_RemovesDuplicateTest()
        {
            var duplicateTourist = testTourists[0];
            var touristsWithDuplicates = new Tourist[] { duplicateTourist, duplicateTourist };

            var tour = new Tour("Тест", "EUR-123", touristsWithDuplicates);

            Assert.That(tour.TouristCount, Is.EqualTo(1));
        }

        [Test]
        public void GetEnumeratorTest()
        {
            int count = 0;
            foreach (var tourist in testTour)
            {
                count++;
            }

            Assert.That(count, Is.EqualTo(2));
        }

        [Test]
        public void TouristCountTest()
        {
            Assert.That(testTour.TouristCount, Is.EqualTo(2));
        }
    }
}
