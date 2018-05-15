using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AD.Models
{
    public class Colours
    {
        [Key]
        public int ColourId { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }


        public virtual People People { get; set; }
        public virtual FavouriteColours FavouriteColours { get; set; }
    }
}