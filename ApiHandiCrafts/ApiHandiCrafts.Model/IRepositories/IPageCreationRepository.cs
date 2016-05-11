using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Models;

namespace ApiHandiCrafts.Contract.ModelRepositories
{
    public interface IPageCreationRepository
    {
        IEnumerable<PageContentDesign> GetAll();

        PageContentDesign GetById(int id);
        PageContentDesign GetPageDesign(string pageName);
        void Insert(PageContentDesign entity);

        void Update(int id, PageContentDesign entity);

        void Delete(int id);
    }
}
