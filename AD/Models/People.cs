using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AD.Models
{
    public class People
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsValid { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Colours> Colours { get; set; }
    }
}