using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCData.Models
{
    public class PeopleService : IPeopleService
    {
        private IPeopleRepo peopleRepo;

        public Person Add(CreatePersonViewModel person)
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel All()
        {
            throw new NotImplementedException();
        }

        public Person Edit(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public PeopleViewModel FindBy(PeopleViewModel search)
        {
            throw new NotImplementedException();
        }

        public Person FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
