using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductModels
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
