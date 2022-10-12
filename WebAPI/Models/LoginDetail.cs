using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class LoginDetail
    {

        public string UserId { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}