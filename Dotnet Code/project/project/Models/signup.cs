//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class signup
    {
        [Required(ErrorMessage="Id is Required")]
        public int id { get; set; }

         [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

         [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

         [Required(ErrorMessage = "Gender is Required")]
        public string Gender { get; set; }

         [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

         [Required(ErrorMessage = "Mobile_no. is Required")]
        public int Mobile_No { get; set; }

         [Required(ErrorMessage = "Password is Required")]
        public int password { get; set; }
    }
}
