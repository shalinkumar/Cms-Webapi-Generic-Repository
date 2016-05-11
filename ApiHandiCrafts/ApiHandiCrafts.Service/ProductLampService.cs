using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.IRepositories;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Service
{
    public class ProductLampService : IProductLampService
    {
        private readonly IProductLampRepository _productLampRepository;


        public ProductLampService(IProductLampRepository productLampRepository)
        {
            _productLampRepository = productLampRepository;
        }
        public void Create(Products entity)
        {
            _productLampRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _productLampRepository.Delete(id);
        }

        public IEnumerable<Products> GetAll()
        {
            return _productLampRepository.GetAll();
        }

        public void Update(Products entity)
        {
            _productLampRepository.Update(1, entity);
        }

        public Products GetById(int id)
        {
            return _productLampRepository.GetById(id);
        }
    }
}
