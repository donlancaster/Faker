using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FakerLib.Interfaces;
using FakerLib.Generators;

namespace UnitTest
{

    [TestClass]
    public class UserFieldsTest
    {

        User user;
        [TestInitialize]
        public void Setup()
        {
            FakerLib.Faker faker = new FakerLib.Faker();
            user = faker.Create<User>();
        }
        [TestMethod]

        public void MoneyFieldTest()
        {
            Assert.AreEqual(user.money == default(double), false, "÷¸");
        }
        [TestMethod]
        public void NameFieldTest()
        {
            Assert.AreEqual(user.name == default(string), false, "÷¸");
        }
        [TestMethod]
        public void AgeFieldTest()
        {
            Assert.AreEqual(user.age == default(int), false, "÷¸");
        }
        [TestMethod]
        public void ProfileFieldTest()
        {
            Assert.AreEqual(user.name == null, false, "÷¸");
        }
        [TestMethod]
        public void DogsListTest()
        {
            Assert.AreEqual(user.dogs == null, false, "÷¸");
        }


    }

    [TestClass]
    public class GeneratorsTest
    {

        [TestMethod]
        public void CharGeneratorTest()
        {
            IGenerator generator = new CharGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(char));
        }

        [TestMethod]
        public void StringGeneratorTest()
        {
            IGenerator generator = new StringGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(string));
        }

        [TestMethod]
        public void IntGeneratorTest()
        {
            IGenerator generator = new IntGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(int));
        }

        [TestMethod]
        public void DoubleGeneratorTest()
        {
            IGenerator generator = new CharGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(char));
        }

        [TestMethod]
        public void CollectionGeneratorTest()
        {
            FakerLib.Faker faker = new FakerLib.Faker();
            List<int> list = faker.Create<List<int>>();
            ICollection<double> icoll = faker.Create<ICollection<double>>();
            List<List<char>> difficult = faker.Create<List<List<char>>>();
            Assert.AreEqual(list == null, false);
            char b = difficult[0][0];
            Assert.AreEqual(b == default(char), false);
        }
    }

    [TestClass]
    public class UnitTest1
    {

    





    }
}
