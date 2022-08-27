using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Image { get; set; }
        public string  Title { get; set; }
        public string  Time { get; set; }
        public int Kcl { get; set; }
        public string Contents  { get; set; }
        public string Description  { get; set; }
       

       
    }
}
