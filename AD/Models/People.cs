using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AD.Models
{
    public class People
    {
        [Key]
        public int PersonId { get=>PersonId; set=>PersonId=value; }
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthorised { get; set; }
        public bool IsValid { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Colours> Colours { get; set; }
    }
}