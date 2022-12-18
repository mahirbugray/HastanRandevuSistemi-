using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   
    public class Secretary
    {
        [Key]
        public int SecretaryID { get; set; }
        [StringLength(50)]
        public string SecretaryName { get; set; }
        [StringLength(50)]
        public string SecretaryLastname { get; set; }
        [StringLength(11)]
        public string TC { get; set; }
        [StringLength(50)]
        public string SecretaryPassword { get; set; }

        public ICollection<Branch> Branches { get; set; }
    }
}
