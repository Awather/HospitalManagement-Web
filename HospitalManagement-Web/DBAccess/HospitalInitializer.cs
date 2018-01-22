using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HospitalManagement_Web.Models;

namespace HospitalManagement_Web.DBAccess
{
    public class HospitalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HospitalContext>
    {

        protected override void Seed(HospitalContext context)
        {
            var patients = new List<Patient>
            {
            new Patient{SocialSecurityNumber=19600505-1111, FirstMidName="Carson",LastName="Alexander", Gender="Male", Address="Greenback", ZipCode=5151, City="Gothen", PhoneNumber = 0736696582, RegistrationDate = DateTime.Parse("2005-09-01")},
            new Patient{SocialSecurityNumber=19750612-2222, FirstMidName="Meredith",LastName="Alonso", Gender="Female", Address="Stenback", ZipCode=5252, City="Skone", PhoneNumber = 073885599, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19811220-3333, FirstMidName="Arturo",LastName="Anand",Gender="Male", Address="Hardback", ZipCode=5353, City="Gavle", PhoneNumber = 0722445588, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19910918-4444, FirstMidName="Gytis",LastName="Barzdukas",Gender="Female", Address="Seaback", ZipCode=5454, City="Skone", PhoneNumber = 0745678911, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19770605-5555, FirstMidName="Yan",LastName="Li",Gender="Female", Address="Lakeback", ZipCode=5555, City="Stockhlm", PhoneNumber = 077894561, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19880130-6666, FirstMidName="Peggy",LastName="Justice",Gender="Female", Address="Treeback", ZipCode=5656, City="Gothen", PhoneNumber = 079876543, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19900813-7777, FirstMidName="Nino",LastName="Olivetto",Gender="Male", Address="Stenback", ZipCode=5757, City="Gothen", PhoneNumber = 076541237, RegistrationDate = DateTime.Parse("2002-09-01")},
            };

            patients.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            var departments = new List<Department>
                {
                new Department{DepartmentID=1010, Title= "No department assigned"},
                new Department{DepartmentID=2020, Title= "ICU"},
                new Department{DepartmentID=3030, Title= "Maternity department"},
                new Department{DepartmentID=4040, Title= "Discharge lounge"}
                };

            departments.ForEach(p => context.Departments.Add(p));
            context.SaveChanges();

            var registrations = new List<Registration>
                {
                new Registration{PatientID = 1, DepartmentID = 1010},
                new Registration{PatientID = 2, DepartmentID = 1010},
                new Registration{PatientID = 3, DepartmentID = 2020},
                new Registration{PatientID = 3, DepartmentID = 1010},
                new Registration{PatientID = 4, DepartmentID = 2020},
                new Registration{PatientID = 5, DepartmentID = 1010},
                new Registration{PatientID = 6, DepartmentID = 3030},
                new Registration{PatientID = 7, DepartmentID = 4040}
                
                };

            registrations.ForEach(p => context.Registrations.Add(p));
            context.SaveChanges();



        }

    }
}