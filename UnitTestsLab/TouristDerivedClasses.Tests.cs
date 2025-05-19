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
    public class TouristDerivedClassesTests
    {
        [Test]
        public void ForeignTourist_ConstructorTest()
        {
            var tourist = GetForeignTourist();
            Assert.That(tourist.PassportNumber, Is.EqualTo("123456789"));
            Assert.That(tourist.RequiredVisas, Is.EqualTo("США, Шенген"));
        }

        [Test]
        public void ForeignTourist_GetInfoTest()
        {
            var tourist = GetForeignTourist();
            var info = tourist.GetInfo();

            Assert.That(info.Contains("Паспорт: 123456789"));
            Assert.That(info.Contains("Визы: США, Шенген"));
        }

        [Test]
        public void SanatoriumTourist_ConstructorTest()
        {
            var tourist = GetSanatoriumTourist();
            Assert.That(tourist.MedicalPolicyNumber, Is.EqualTo("MP123456"));
            Assert.That(tourist.Diagnosis, Is.EqualTo("Остеохондроз"));
        }

        [Test]
        public void SanatoriumTourist_GetInfoTest()
        {
            var tourist = GetSanatoriumTourist();
            var info = tourist.GetInfo();

            Assert.That(info.Contains("Полис: MP123456"));
            Assert.That(info.Contains("Диагноз: Остеохондроз"));
        }

        [Test]
        public void ChildTourist_ConstructorTest()
        {
            var tourist = GetChildTourist();
            Assert.That(tourist.Age, Is.EqualTo(10));
            Assert.That(tourist.Gender, Is.EqualTo("мальчик"));
            Assert.That(tourist.Vacation, Is.EqualTo(VacationType.InCamp));
        }

        [Test]
        public void ChildTourist_GetInfoTest()
        {
            var tourist = GetChildTourist();
            var info = tourist.GetInfo();

            Assert.That(info.Contains("Возраст: 10"));
            Assert.That(info.Contains("Пол: мальчик"));
            Assert.That(info.Contains("Отдых: в детском оздоровительном лагере"));
        }

        private ForeignTourist GetForeignTourist()
        {
            var tourist = new ForeignTourist("Иван", "Петров", 14, "A123", PayType.Cash, "123456789", "США, Шенген");
            tourist.StartDate = new DateTime(2025, 6, 1);
            tourist.Cost = 120000;
            return tourist;
        }

        private SanatoriumTourist GetSanatoriumTourist()
        {
            var tourist = new SanatoriumTourist("Анна", "Сидорова", 21, "S456", PayType.BankAccountTransfer, "MP123456", "Остеохондроз");
            tourist.StartDate = new DateTime(2025, 7, 15);
            tourist.Cost = 75000;
            return tourist;
        }

        private ChildTourist GetChildTourist()
        {
            var tourist = new ChildTourist("Петя", "Иванов", 10, "C789", PayType.CreditCard, 10, "мальчик", VacationType.InCamp);
            tourist.StartDate = new DateTime(2025, 8, 1);
            tourist.Cost = 50000;
            return tourist;
        }
    }
}
