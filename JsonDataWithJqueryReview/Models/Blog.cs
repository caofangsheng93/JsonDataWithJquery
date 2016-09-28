using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JsonDataWithJqueryReview.Models
{
    /// <summary>
    /// 博客实体
    /// </summary>
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [MaxLength(200000)]
        [Required]
        public string BlogContent { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime AddedDate { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]  //数据注解配置外键
        public virtual BlogCategory BlogCategory { get; set; }
    }
}