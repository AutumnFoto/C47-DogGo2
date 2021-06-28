using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo2.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);

        void AddWalker(Walker walker);

        void UpdateWalker(Walker walker);

        void DeleteWalker(int id);
    }
}