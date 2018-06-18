using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductModels
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public virtual Category cat { get; set; } //导航属性


    }
}
