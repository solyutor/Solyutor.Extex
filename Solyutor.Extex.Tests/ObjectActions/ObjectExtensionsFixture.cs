using System.Collections.Generic;
using NUnit.Framework;
using SharpTestsEx;
using Solyutor.Extex.ObjectActions;

namespace Solyutor.Extex.Tests.ObjectActions
{
    [TestFixture]
    public class ObjectExtensionsFixture
    {
        [Test]
        public void IsNull_and_IsNull_works_as_expected_if_null()
        {
            object obj = null;

            obj.Satisfy(o =>
                        o.IsNull() == true &&
                        o.IsNotNull() == false);
        }

        [Test]
        public void IsNull_and_IsNull_works_as_expected_if_instance()
        {
            var obj = new object();

            obj.Satisfy(o =>
                        o.IsNull() == false &&
                        o.IsNotNull() == true);
        }

        [Test]
        public void DoIfNull_works_if_null()
        {
            object @null = null;
            bool okForNull = false;
            
            object instance = new object();
            bool okForInstance = true;

            @null.DoIfNull(delegate { okForNull = true; });

            instance.DoIfNull(delegate { okForInstance = false; });

            Assert.That(okForNull);
            Assert.That(okForInstance);
        }

        [Test]
        public void DoIfNotNull_works_if_not_null()
        {
            object @null = null;
            bool okForNull = true;

            object instance = new object();
            bool okForInstance = false;

            @null.DoIfNotNull(() => okForNull = false );

            instance.DoIfNotNull( () =>okForInstance = true);

            Assert.That(okForNull);
            Assert.That(okForInstance);
        }

        [Test]
        public void DoIfNotNull_works_if_null()
        {
            object @null = null;
            bool okForNull = true;

            object instance = new object();
            object paramterInstance = null;

            @null.DoIfNotNull(o => okForNull = false);

            instance.DoIfNotNull(o => paramterInstance = o);

            Assert.That(okForNull);
            Assert.That(paramterInstance, Is.SameAs(instance));
        }

        [Test]
        public void Cast_will_not_fails_if_ok()
        {
            var list = new List<int>();

            var obj = (object) list;

            var result = obj.CastTo<IList<int>>();

            Assert.That(result, Is.SameAs(list));
        }
    }
}