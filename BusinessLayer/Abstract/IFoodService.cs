using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IFoodService
    {
        void Add(Food food);
        void Delete(Food food);
        void Update(Food food);
        List<Food> GetAll();
        Food GetById(int id);
    }
}
