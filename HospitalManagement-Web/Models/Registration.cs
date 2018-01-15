using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement_Web.Models
{
    public enum Room
    {
        A20, B20, C20, A30, B30, C30, A40, B40, C40
        
    }

    public class Registration
    {

        public int RegistrationID { get; set; }
        public int DepartmentID { get; set; }
        public int PatientID { get; set; }
        public Room? Room { get; set; }


        public virtual Department Department { get; set; }
        public virtual Patient Patient { get; set; }
    }
}