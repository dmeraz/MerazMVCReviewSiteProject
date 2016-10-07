using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerazMVCReviewSiteProject.Models
{
    public class Review
    {
        //Properties
        [Key]
        //ID
        public int ID { get; set; }
        //Title
        public string Title { get; set; }
        //Content
        public string Content { get; set; }
        //Publish Date
        public DateTime PublishDate { get; set; }
        //Etc
        public string TechType { get; set; }
    }
}