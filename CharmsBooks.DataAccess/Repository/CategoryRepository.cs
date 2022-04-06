﻿using CharmsBooks.DataAccess.Repository.IRepository;
using CharmsBooks.Models;
using CharmsBooks.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CharmsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Models.Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Models.Category category)
        {
            // use .Net Linq to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category Id
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == Category.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
