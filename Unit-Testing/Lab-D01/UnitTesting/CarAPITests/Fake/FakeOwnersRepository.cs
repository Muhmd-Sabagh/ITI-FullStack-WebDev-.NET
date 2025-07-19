using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPITests.Fake
{
    internal class FakeOwnersRepository : IOwnersRepository
    {
        public bool AddOwner(Owner owner)
        {
            throw new NotImplementedException();
        }

        public List<Owner> GetAllOwners()
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerById(int id)
        {
            return new Owner(id, "Ahmed");
        }
    }
}
