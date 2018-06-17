using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    //[Table("Product")]//用于生成的表名
    public class Product
    {
        [Key] //主键
        public int ProductID { get; set; }

        [Required] //非空字段
        //[MaxLength(50)]//最大长度
        public string ProductName { get; set; }

        // ?表示字段允许为空
        public int? ProductPrice { get; set; }

        [NotMapped]//计算字段
        public int Count { get; set; }
    }
}