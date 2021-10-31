using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FakerLib.Interfaces;
using FakerLib.Generators;
using PluginLongGenerator;
using FakerLib;

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
        public void DateFieldTest()
        {
            Assert.AreEqual(user.date == default(DateTime), false, "÷¸");
        }

        [TestMethod]
        public void ProfileFieldTest()
        {
            Assert.AreEqual(user.profile == null, false, "÷¸");
        }
        [TestMethod]
        public void DogsListTest()
        {
            Assert.AreEqual(user.dogs == null, false, "÷¸");
        }

        [TestMethod]
        public void DogNameTest()
        {
            foreach (Dog dog in user.dogs)
            {
                Assert.AreEqual(dog.name == default(string), false, "÷¸");
            }
        }

        [TestMethod]
        public void DogLongValueTest()
        {
            Assert.AreEqual(user.dogs[0].longValue == default(long), false, user.dogs[0].longValue.ToString());

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
        public void LongGeneratorTest()
        {
            IGenerator generator = new LongGenerator();
            object generated = generator.Create();
            Assert.AreEqual(generated.GetType(), typeof(long), generated.ToString());
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
    public class PluginsTest
    {
        [TestMethod]
        public void PluginLoadTest()
        {
            Dictionary<Type, IGenerator> plugins = new Dictionary<Type, IGenerator>();
            PluginLoader loader = new PluginLoader(plugins);
            loader.LoadPluginGenerators();
            Assert.AreEqual(plugins.Count, 2, "Wrong number of loaded plugins");
        }
    }

    [TestClass]
    public class UnitTest1
    {







    }
}
