using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerazMVCReviewSiteProject.Models
{
    //Assign Categories of technology type and id# to each review entry
    public class Category
    {
        public int Id { get; set; }
        public string TechType { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}