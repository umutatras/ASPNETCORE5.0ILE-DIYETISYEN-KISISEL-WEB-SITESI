using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AboutMe { get; set; }
        public string Experience { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
    }
}
