using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        [StringLength(50)]
        public string PatientName { get; set; }
        [StringLength(50)]
        public string PatientLastname { get; set; }
        [StringLength(11)]
        public string TC { get; set; }
        [StringLength(50)]
        public string PatientPassword { get; set; }
        [StringLength (10)]
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }


        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
