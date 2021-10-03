using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Models
{
    public class AdminCategoriesViewModel
    {
        public List<Food> Foods { get; set; }
    }

    public class AdminCategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CName { get; set; }
        public string CDescription { get; set; }
       
    }

    public class AdminCategoryEditViewModel
    {
        public int CategoryId { get; set; }
        public string CName { get; set; }
        public string CDescription { get; set; }
        public List<Food> Foods { get; set; }
    }
}
