using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAnotation.Models
{
    public class employee
    {
        [Required(ErrorMessage="hii")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int age { get; set; }
    }
}