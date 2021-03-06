﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiHandiCrafts.Contract.Models;
using ApiHandiCrafts.Contract.Service;

namespace ApiHandiCrafts.Contract.ModelService
{
    public interface IPageCreationService : IEntityService<PageContentDesign>
    {
        PageContentDesign GetById(int id);
        PageContentDesign GetPageDesign(string pageName);
    }
}
