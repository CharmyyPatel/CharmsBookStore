using CharmsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharmsBooks.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Models.Category category);
    }
}
