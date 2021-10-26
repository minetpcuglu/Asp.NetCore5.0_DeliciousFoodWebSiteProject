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
    public class CategoryManager : IGenericService<Category>
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            category.CStatus = true;
            _categoryDal.insert(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
          return  _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetSearchCategory(string name) //*** sıkıntılı 
        {
            return _categoryDal.GetListAll(x=>x.CName==name);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
