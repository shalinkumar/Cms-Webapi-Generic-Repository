using System.Collections.Generic;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Contract.IRepositories
{
    public interface IProductLampRepository
    {
        IEnumerable<Products> GetAll();

        Products GetById(int id);

        void Insert(Products entity);

        void Update(int id, Products entity);

        void Delete(int id);
    }
}
