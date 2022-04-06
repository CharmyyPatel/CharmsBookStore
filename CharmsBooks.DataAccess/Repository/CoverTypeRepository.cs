using CharmsBooks.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmsBooks.DataAccess.Repository
{
    public class CoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public static object Id { get; private set; }

        public void Update(Models.Category category)
        {
            // use .Net Linq to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category Id
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == CoverTypeRepository.Id);
            if (objFromDb != null) // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
