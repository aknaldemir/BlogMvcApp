using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Abstract;

namespace Blog.Entities.Concrete
{
    public class News : IEntity
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }
        public string NewsDescription { get; set; }
        public string NewsBody { get; set; }
        public string NewsImage { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlider { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
       

    }
}
