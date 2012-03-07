using System;
using DependencyInjection.Entities;
using DependencyInjection.Repository;

namespace DependencyInjection.RepositoryImpl
{
    public class PeopleRepositoryImpl : IPeopleRepository
    {
        private readonly string _connString;

        public PeopleRepositoryImpl(string connString)
        {
            if (connString == null)
            {
                throw new ArgumentNullException("connString");
            }
            _connString = connString;
        }

        #region IPeopleRepository Members

        public People GetPeople()
        {
            return new People() { Id = 1, Name = "Teste" };
        }

        #endregion
    }
}
