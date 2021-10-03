using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_DeliciousFoodWebSiteProject.Models
{


    public class AdminFoodViewModel
    {

        public int FoodId { get; set; }
        public string FName { get; set; }
        public string FPrice { get; set; }
        public string FStock { get; set; }
        public string FDescription { get; set; }
        public string FImageUrl { get; set; }
        public List<Category> Categories { get; set; }
    }

    public class AdminFoodsViewModel
    {
        public List<Food> Foods { get; set; }
    }
    public class AdminEditViewModel
    {
        public int FoodId { get; set; }
        public string FName { get; set; }
        public string FPrice { get; set; }
        public string FStock { get; set; }
        public string FDescription { get; set; }
        public string FImageUrl { get; set; }
        public List<Category> Categories { get; set; }
    }
}

