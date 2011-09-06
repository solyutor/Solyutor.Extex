using System;
using NUnit.Framework;
using Solyutor.Extex.RuDates;

namespace Solyutor.Extex.Tests.RuDates
{
    [TestFixture]
    public class DateTimeExtensionsFixture
    {
        [Test]
        public void Test_january()
        {
            Assert.That(22.January(2000), Is.EqualTo(DateTime(1)));
        }

        [Test]
        public void Test_february()
        {
            Assert.That(22.February(2000), Is.EqualTo(DateTime(2)));
        }

        [Test]
        public void Test_march()
        {
            Assert.That(22.March(2000), Is.EqualTo(DateTime(3)));
        }

        [Test]
        public void Test_april()
        {
            Assert.That(22.April(2000), Is.EqualTo(DateTime(4)));
        }

        [Test]
        public void Test_may()
        {
            Assert.That(22.May(2000), Is.EqualTo(DateTime(5)));
        }

        [Test]
        public void Test_june()
        {
            Assert.That(22.June(2000), Is.EqualTo(DateTime(6)));
        }

        [Test]
        public void Test_july()
        {
            Assert.That(22.July(2000), Is.EqualTo(DateTime(7)));
        }

        [Test]
        public void Test_august()
        {
            Assert.That(22.August(2000), Is.EqualTo(DateTime(8)));
        }

        [Test]
        public void Test_septemeber()
        {
            Assert.That(22.September(2000), Is.EqualTo(DateTime(9)));
        }

        [Test]
        public void Test_october()
        {
            Assert.That(22.October(2000), Is.EqualTo(DateTime(10)));
        }

        [Test]
        public void Test_november()
        {
            Assert.That(22.November(2000), Is.EqualTo(DateTime(11)));
        }

        [Test]
        public void Test_december()
        {
            Assert.That(22.December(2000), Is.EqualTo(DateTime(12)));
        }

        private static DateTime DateTime(int month)
        {
            return new DateTime(2000, month, 22);
        }
    }
}