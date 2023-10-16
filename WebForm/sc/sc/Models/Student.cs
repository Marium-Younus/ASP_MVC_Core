using System;
using System.Collections.Generic;

namespace sc.Models
{
    public partial class Student
    {
        public int SId { get; set; }
        public string SName { get; set; } = null!;
        public string SEmail { get; set; } = null!;
        public string SBc { get; set; } = null!;
    }
}
