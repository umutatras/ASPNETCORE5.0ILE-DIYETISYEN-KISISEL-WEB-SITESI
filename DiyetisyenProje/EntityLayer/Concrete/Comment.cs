using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentDescription { get; set; }
        public int BlogID { get; set; }
        public Blog   Blog { get; set; }
    }
}
