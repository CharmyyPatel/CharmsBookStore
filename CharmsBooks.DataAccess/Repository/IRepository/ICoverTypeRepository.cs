using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharmsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository: Repository<CoverTypeRepository>
    {
        void Update(CoverTypeRepository coverTypeRepository);
    }
}
