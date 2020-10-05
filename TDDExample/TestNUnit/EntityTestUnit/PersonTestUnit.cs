using Domain.Entity;
using NUnit.Framework;

namespace TestNUnit
{
    public class PersonTestUnit
    {

        [Test]
        public void PeopleIsValid()
        {
            string cpf = "12345678901";
            string name = "Teste Henrique";

            Person person = new Person(cpf, name);

            Assert.IsNotNull(person);
            Assert.IsTrue(person.Cpf == cpf);
            Assert.IsTrue(person.Name == name);
        }

        [Test]
        public void PeopleNotCreateCPF()
        {
            string cpf = null;
            string name = "Teste Henrique";

            Assert.Throws<EntityException>(() => new Person(cpf, name));
        }

        [Test]
        public void PeopleNotCreateName()
        {
            string cpf = "12345678901";
            string name = null;

            Assert.Throws<EntityException>(() => new Person(cpf, name));
        }

    }
}