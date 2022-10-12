using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public partial class Issue
    {
        public int IssueID { get; set; }
        public Nullable<int> Book_NO { get; set; }
        public string UserId { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }

        public virtual MBook Book { get; set; }
        public virtual LoginDetail LoginDetail { get; set; }
    }
}