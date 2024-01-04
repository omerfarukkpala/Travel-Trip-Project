using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTravelTrip.Models.Classes
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentName { get; set; }

        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}