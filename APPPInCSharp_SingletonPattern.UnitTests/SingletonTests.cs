using APPPInCSharp_SingletonPattern.Console;
using NUnit.Framework;
using System;
using System.Reflection;

namespace APPPInCSharp_SingletonPattern.UnitTests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void CreateSingleton()
        {
            Singleton s = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            Assert.That(s, Is.EqualTo(s2));
        }

        [Test]
        public void NoPublicConstructors()
        {
            Type singleton = typeof(Singleton);
            ConstructorInfo[] ctrs = singleton.GetConstructors();
            bool hasPublicConstructor = false;
            foreach (var c in ctrs)
            {
                if (c.IsPublic)
                {
                    hasPublicConstructor = true;
                    break;
                }
            }
            Assert.That(hasPublicConstructor, Is.False);
        }
    }
}