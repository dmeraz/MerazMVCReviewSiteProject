using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}