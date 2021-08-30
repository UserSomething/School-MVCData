using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_MVCData.Models
{
    public class PeopleViewModel
    {
        public PeopleService peopleService { get; set; }
        public InMemoryPeopleRepo inMemoryPeopleRepo { get; set; }
    }
}
