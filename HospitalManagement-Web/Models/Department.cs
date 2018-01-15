using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement_Web.Models
{
    public class Department
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string Title { get; set; }


        public virtual ICollection<Registration> Registrations { get; set; }

    }
}