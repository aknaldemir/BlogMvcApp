using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entities.Abstract;
using Microsoft.Win32;

namespace Blog.Entities.Concrete
{
    public class Comment: IEntity
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
