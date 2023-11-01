using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database_FirstApproach.Models
{
    public partial class Employee
    {
        public int EId { get; set; }
        [Required(ErrorMessage ="Please Enter Name")]
        public string? EName { get; set; }
       
        public string? EImage { get; set; }
    }
}
