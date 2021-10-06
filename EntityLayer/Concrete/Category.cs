using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(100)]
        public string CName { get; set; }

        [StringLength(850)]
        public string CDescription { get; set; }
        public bool CStatus { get; set; }

        public ICollection<Food> Foods { get; set; }

    }
}
