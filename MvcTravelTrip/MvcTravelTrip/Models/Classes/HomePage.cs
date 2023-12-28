using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTravelTrip.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int HomePageID { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
    }
}