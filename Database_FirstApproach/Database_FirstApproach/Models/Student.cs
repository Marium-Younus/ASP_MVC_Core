using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database_FirstApproach.Models
{
    public partial class Student
    {
        public int SId { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]
        public string? SName { get; set; }
        [Required(ErrorMessage = "Please Enter Email")]
        public string? SEmail { get; set; }
        [Required(ErrorMessage = "Please Enter Phone")]
        public string? SPhone { get; set; }
        [Required(ErrorMessage = "Please Select Gender")]
        public string? SGender { get; set; }
        [Required(ErrorMessage = "Please Enter Age")]
        public int? SAge { get; set; }
        [Required(ErrorMessage = "Please Select City")]
        public string? SCity { get; set; }
    }
}
