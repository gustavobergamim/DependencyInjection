using System;
using DependencyInjection.Business;
using DependencyInjection.Entities;
using DependencyInjection.Repository;

namespace DependencyInjection.BusinessImpl
{
    public class PeopleBusinessImpl : IPeopleBusiness
    {
        private readonly IPeopleRepository _repository;

        public PeopleBusinessImpl(IPeopleRepository repository)
        {
            if(repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        #region IPeopleRepository Members

        public People GetPeople()
        {
            return _repository.GetPeople();
        }

        #endregion
    }
}
