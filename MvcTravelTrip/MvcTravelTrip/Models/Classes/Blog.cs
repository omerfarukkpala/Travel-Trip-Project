using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTravelTrip.Models.Classes
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogHeading { get; set; }
        public DateTime BlogDate { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}