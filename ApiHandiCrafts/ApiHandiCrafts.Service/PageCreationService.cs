using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.ModelRepositories;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.ModelService;

namespace ApiHandiCrafts.Service
{
    class PageCreationService : IPageCreationService
    {
        private readonly IPageCreationRepository _pageCreationRepository;


        public PageCreationService(IPageCreationRepository pageCreationRepository)
        {
            _pageCreationRepository = pageCreationRepository;
        }

        public void Create(PageContentDesign entity)
        {
            _pageCreationRepository.Insert(entity);
        }

        public void Delete(int id)
        {
            _pageCreationRepository.Delete(id);
        }

        public IEnumerable<PageContentDesign> GetAll()
        {
            return _pageCreationRepository.GetAll();
        }

        public void Update(PageContentDesign entity)
        {
            _pageCreationRepository.Update(1, entity);
        }

        public PageContentDesign GetById(int id)
        {
            return _pageCreationRepository.GetById(id);
        }

        public PageContentDesign GetPageDesign(string pageName)
        {
            return _pageCreationRepository.GetPageDesign(pageName);
        }
    }
}
