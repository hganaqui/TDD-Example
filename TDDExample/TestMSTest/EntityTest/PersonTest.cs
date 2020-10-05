using Domain.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMSTest.EntityTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PeopleIsValid()
        {
            string cpf = "12345678901";
            string name = "Teste Henrique";

            Person person = new Person(cpf, name);

            Assert.IsNotNull(person);
            Assert.IsTrue(person.Cpf == cpf);
            Assert.IsTrue(person.Name == name);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PeopleNotCreateCPF()
        {
            string cpf = null;
            string name = "Teste Henrique";

            Person person = new Person(cpf, name);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PeopleNotCreateName()
        {
            string cpf = "12345678901";
            string name = null;

            Person person = new Person(cpf, name);

        }
    }
}
