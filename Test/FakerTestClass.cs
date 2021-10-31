
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Threading;
using System;
using FakerLib.Interfaces;
using FakerLib.Generators;

namespace Test
{
    [TestClass]
    class FakerTestClass
    {


        [TestMethod]
        public void GeneratorTest()
        {
            IGenerator generator = new CharGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(char));
        }

        [TestMethod]
        public void UserFieldsTest()
        {
            FakerLib.Faker faker = new FakerLib.Faker();
            User user = faker.Create<User>();
            Assert.AreEqual(user.money == default(double), false, "чё");
        }
    }
}
