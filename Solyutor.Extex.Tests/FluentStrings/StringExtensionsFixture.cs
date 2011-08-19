using NUnit.Framework;
using Solyutor.Extex.FluentStrings;

namespace Solyutor.Extex.Tests.FluentStrings
{
    [TestFixture]
    public class StringExtensionsFixture
    {
        [Test]
        public void IsNullOrEmpty_return_true_if_null()
        {
            string nullString = null;

            Assert.That(nullString.IsNullOrEmpty(), Is.True);
        }

        [Test]
        public void IsNullOrEmpty_return_true_if_empty()
        {
            var nullString = string.Empty;

            Assert.That(nullString.IsNullOrEmpty(), Is.True);
        }

        [Test]
        public void IsNullOrEmpty_return_false_if_not_empty()
        {
            var @string = "Go-go";

            Assert.That(@string.IsNullOrEmpty(), Is.False);
        }

        [Test]
        public void IsNullOrEmptyOrWhiteSpace_return_true_if_whitespaces()
        {
            var @string = "    ";

            Assert.That(@string.IsNullOrEmptyOrWhiteSpace(), Is.True);
        }

        [Test]
        public void IsNullOrEmptyOrWhiteSpace_return_false_if_text()
        {
            var @string = " fsdfa   ";

            Assert.That(@string.IsNullOrEmptyOrWhiteSpace(), Is.False);
        }
    }
}