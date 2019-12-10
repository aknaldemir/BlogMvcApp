using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Abstract;

namespace Blog.Entities.Concrete
{
    public class Tag : IEntity
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public ICollection<Article> Articles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
