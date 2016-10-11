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
        //Add Model and Brand
        public string ModelBrand { get; set; }
        //Attempt to add Image Path, return to later
        //Add Image Path source: http://stackoverflow.com/questions/33012853/how-to-add-image-property-in-my-model
        //Adding after build https://www.asp.net/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/adding-a-new-field-to-the-movie-model-and-table
        //public string Image { get; set; }

        //Link Categories to track Reviews
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}