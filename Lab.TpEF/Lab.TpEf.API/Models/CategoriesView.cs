using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.TpEf.API.Models
{
    public class CategoriesView
    {
        public int CategoryID { get; set; }
        
        [Required]
        [StringLength(15), MinLength(3)]
        public string CategoryName { get; set; }
        
        [Required]
        [StringLength(50), MinLength(5)]
        public string Description { get; set; }
    }
}