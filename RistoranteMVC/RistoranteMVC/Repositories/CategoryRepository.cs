﻿using RistoranteMVC.Contracts;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RistoranteMVCDbContext dbContext) : base(dbContext)
        {

        }
    }
}
