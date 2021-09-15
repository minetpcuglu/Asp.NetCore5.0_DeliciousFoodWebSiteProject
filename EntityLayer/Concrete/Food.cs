using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Food
    {
        [Key]
        public int FoodId { get; set; }

        [StringLength(100)]
        public string FName  { get; set; }

     

        [StringLength(800)]
        public string FDescription  { get; set; }

        public double FPrice  { get; set; }
    
        public string FImageUrl  { get; set; }
       
        public int FStock  { get; set; }


        /*İlişkiler*/
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
