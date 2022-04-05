using CharmsBooks.DataAccess.Data;
using CharmsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharmsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository:IRepository<Models.Category>
    {
        void Update(Models.Category category);
    }
}
