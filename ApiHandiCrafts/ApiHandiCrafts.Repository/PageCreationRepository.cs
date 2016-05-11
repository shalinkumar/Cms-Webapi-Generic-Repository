using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Repositories;

namespace ApiHandiCrafts.Repository
{
    class PageCreationRepository : IPageCreationRepository
    {
        private readonly IGenericRepository<PageContentDesign> _genericRepository;
        private int _idIncrement;

        public PageCreationRepository(IGenericRepository<PageContentDesign> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public IEnumerable<PageContentDesign> GetAll()
        {
            var value = _genericRepository.Queryable().AsEnumerable();
            return value;
        }

        public PageContentDesign GetById(int id)
        {
            return _genericRepository.Queryable().Where(x => x.Id == id).AsEnumerable().SingleOrDefault();
        }

        public PageContentDesign GetPageDesign(string pageName)
        {
            return _genericRepository.Queryable().Where(x => x.PageName == pageName).AsEnumerable().SingleOrDefault();
        }

        public void Insert(PageContentDesign entity)
        {
            var value = _genericRepository.Queryable().AsEnumerable().LastOrDefault();
            if (value == null)
            {
                _idIncrement = 1;
            }
            else
            {
                _idIncrement = value.Id;
                _idIncrement++;
            }
            entity.Id = _idIncrement;

            _genericRepository.Insert(entity);
        }

        public void Update(int id, PageContentDesign entity)
        {
            _genericRepository.Update(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }
    }
}
