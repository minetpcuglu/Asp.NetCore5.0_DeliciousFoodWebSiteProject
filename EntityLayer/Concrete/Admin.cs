using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [StringLength(50)]
        public string Name{ get; set; }

        [StringLength(55)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }
        public string Password { get; set; }

        [StringLength(1)]
        public string AdminRole { get; set; }
    }
}
