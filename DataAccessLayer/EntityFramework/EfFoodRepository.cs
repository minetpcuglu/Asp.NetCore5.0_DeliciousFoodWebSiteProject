using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfFoodRepository : GenericRepository<Food>, IFoodDal
    {
        public List<Food> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Foods.Include(x => x.Category).ToList();
            }
        }
    }
}
