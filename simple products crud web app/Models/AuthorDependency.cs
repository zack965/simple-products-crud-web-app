using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace simple_products_crud_web_app.Models
{
    public class AuthorDependency
    {
        [Key]
        public int AuthId { get; set; }
        [Required]
        public string AuthName { get; set; }
        [Required]
        public string AuthDesc { get; set; }
       
    }
}
