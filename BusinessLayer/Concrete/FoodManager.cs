using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;

        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void Add(Food food)
        {
            _foodDal.insert(food);
        }

        public void Delete(Food food)
        {
            _foodDal.Delete(food);
        }

        public List<Food> GetAll()
        {
            return _foodDal.GetAll();
        }

     
        public Food GetById(int id)
        {
            return _foodDal.GetById(id);
        }

        public List<Food> FoodListGetByCategory(int id)
        {
            return _foodDal.GetListAll(x => x.CategoryId == id);
        }

        public List<Food> GetListWithCategory()
        {
            return _foodDal.GetListWithCategory();
        }

        public void Update(Food food)
        {
            _foodDal.Update(food);
        }
    }
}
