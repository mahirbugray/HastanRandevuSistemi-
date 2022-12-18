using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }
        [StringLength(50)]
        public string BranchName { get; set; }

        
        public int SecretaryID { get; set; }
        public virtual Secretary Secretary { get; set; }

        public ICollection<Doctor> Doctors { get; set; }

    }

}
