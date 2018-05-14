using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AD.Models
{
    public class FavouriteColours
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public  int FcId { get; set; }

        public virtual ICollection<Colours>Colours { get; set; }
    }
}