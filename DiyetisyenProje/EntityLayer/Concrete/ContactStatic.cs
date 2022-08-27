using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactStatic
    {
        [Key]
        public int ContactStaticID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
