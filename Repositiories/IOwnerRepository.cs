using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DogGo2.Repositiories
{
    public interface IOwnerRepository
    {

        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
        void AddOwner(Owner owner);

        void UpdateOwner(Owner owner);

        void DeleteOwner(int id);
    }
}
