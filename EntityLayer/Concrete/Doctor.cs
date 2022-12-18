using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{   
    
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [StringLength (50)]
        public string DoctorName { get; set; }
        [StringLength (50)]
        public string DoctorLastname { get; set; }
        [StringLength (11)]
        public string TC { get; set; }
        [StringLength (50)]
        public string DoctorPassword { get; set; }


        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }

        public ICollection<Patient> Patients { get; set; }

    }
}
