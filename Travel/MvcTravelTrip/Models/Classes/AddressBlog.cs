using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTravelTrip.Models.Classes
{
    public class AddressBlog
    {
        [Key]
        public int AddressBlogID { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string OpenAddress { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string Location { get; set; }
    }
}