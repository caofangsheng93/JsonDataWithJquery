using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JsonDataWithJqueryReview.Models
{
    public class BlogCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}