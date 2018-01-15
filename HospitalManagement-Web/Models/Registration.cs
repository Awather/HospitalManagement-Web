using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement_Web.Models
{
    public class Registration
    {

        public int RegistrationID { get; set; }
        public int DepartmentID { get; set; }
        public int PatientID { get; set; }


        public virtual Department Department { get; set; }
        public virtual Patient Patient { get; set; }
    }
}