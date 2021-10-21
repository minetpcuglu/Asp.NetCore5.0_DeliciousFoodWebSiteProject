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
      

        List<Food> GetListWithCategory();
        List<Food> FoodListGetByCategory(int id); //Include metodu kullanımı için yazar göre listeleme

  
    }
}
