using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class MBook
    {
        public int Book_No { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Category { get; set; }
        public Nullable<int> Availability { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}