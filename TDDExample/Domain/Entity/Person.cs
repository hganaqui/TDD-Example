using System;

namespace Domain.Entity
{
    public class Person
    {
        public Person(string cpf, string name)
        {
            ValidateCPFName(cpf, name);
            Cpf = cpf;
            Name = name;
        }

        public string Cpf  { get; private set; }
        public string Name { get; private set; }

        private void ValidateCPFName(string cpf, string name)
        {
           if(string.IsNullOrEmpty(cpf))
                throw new EntityException("Pessoa.Cpf");

            if(string.IsNullOrEmpty(name))
                throw new EntityException("Pessoa.Name");
        }
    }
}
