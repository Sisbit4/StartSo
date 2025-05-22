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
    public class DiversityTouristTests
    {
        [Test]
        public void ForeignTourist_ConstructorTest()
        {
            var tourist = new ForeignTourist(
                "Иван", "Иванов", "EUR-123", "15.07.2023",
                TimeSpan.FromDays(14), 50000, PaymentType.CreditCard,
                "123456789", "Шенген");

            Assert.That(tourist.TourCode, Is.EqualTo("EUR-123"));
            Assert.That(tourist.PassportNumber, Is.EqualTo("123456789"));
            Assert.That(tourist.RequiredVisas, Is.EqualTo("Шенген"));
            
        }

        [Test]
        public void ForeignTourist_GetInfoTest()
        {
            var tourist = new ForeignTourist(
                "Иван", "Иванов", "EUR-123", "15.07.2023",
                TimeSpan.FromDays(14), 50000, PaymentType.CreditCard,
                "123456789", "Шенген");

            var info = tourist.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[0], Is.EqualTo("Иван Иванов"));
            Assert.That(info[1], Contains.Substring("Тур: EUR-123"));
            Assert.That(info[2], Is.EqualTo("Загранпаспорт: 123456789"));
            Assert.That(info[3], Is.EqualTo("Необходимые визы: Шенген"));
        }

        [Test]
        public void SanatoriumTourist_ConstructorTest()
        {
            var tourist = new SanatoriumTourist(
                "Мария", "Петрова", "SAN-456", "01.08.2023",
                TimeSpan.FromDays(21), 75000, PaymentType.BankTransfer,
                "POL987654", "Остеохондроз");

            Assert.That(tourist.TourCode, Is.EqualTo("SAN-456"));
            Assert.That(tourist.MedicalPolicyNumber, Is.EqualTo("POL987654"));
            Assert.That(tourist.Diagnosis, Is.EqualTo("Остеохондроз"));

        }

        [Test]
        public void SanatoriumTourist_GetInfoTest()
        {
            var tourist = new SanatoriumTourist(
                "Мария", "Петрова", "SAN-456", "01.08.2023",
                TimeSpan.FromDays(21), 75000, PaymentType.BankTransfer,
                "POL987654", "Остеохондроз");

            var info = tourist.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[0], Is.EqualTo("Мария Петрова"));
            Assert.That(info[1], Contains.Substring("Тур: SAN-456"));
            Assert.That(info[2], Is.EqualTo("Мед. полис: POL987654"));
            Assert.That(info[3], Is.EqualTo("Диагноз: Остеохондроз"));
        }

        [Test]
        public void ChildTourist_ConstructorTest()
        {
            var tourist = new ChildTourist(
                "Алексей", "Сидоров", "KID-789", "10.06.2023",
                TimeSpan.FromDays(10), 30000, PaymentType.Cash,
                8, PersonGender.Male, VacationType.WithParents);

            Assert.That(tourist.Age, Is.EqualTo(8));
            Assert.That(tourist.Gender, Is.EqualTo(PersonGender.Male));
            Assert.That(tourist.VacationType, Is.EqualTo(VacationType.WithParents));
        }

        [Test]
        public void ChildTourist_GetInfoTest()
        {
            var tourist = new ChildTourist(
                "Алексей", "Сидоров", "KID-789", "10.06.2023",
                TimeSpan.FromDays(10), 30000, PaymentType.Cash,
                8, PersonGender.Male, VacationType.WithParents);

            var info = tourist.GetInfo();

            Assert.That(info.Length, Is.EqualTo(5));
            Assert.That(info[0], Is.EqualTo("Алексей Сидоров"));
            Assert.That(info[1], Contains.Substring("Тур: KID-789"));
            Assert.That(info[2], Is.EqualTo("Возраст: 8"));
            Assert.That(info[3], Is.EqualTo("Пол: мужской"));
            Assert.That(info[4], Is.EqualTo("Тип отдыха: с родителями"));
        }
    }
}
