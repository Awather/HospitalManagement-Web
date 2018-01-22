using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement_Web.Models
{
    public class Patient
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }


        public virtual ICollection<Registration> Registrations { get; set; }
    }
}