namespace HospitalManagement_Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HospitalManagement_Web.Models;
    using System.Collections.Generic;


    internal sealed class Configuration : DbMigrationsConfiguration<HospitalManagement_Web.DBAccess.HospitalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HospitalManagement_Web.DBAccess.HospitalContext context)
        {
            var patients = new List<Patient>
            {
            new Patient{SocialSecurityNumber=19600505-1111, FirstMidName="Carson",LastName="Alexander", Gender="Male",
                Address ="Greenback", ZipCode=5151, City="Gothen", PhoneNumber = 0736696582, RegistrationDate = DateTime.Parse("2005-09-01")},
            new Patient{SocialSecurityNumber=19750612-2222, FirstMidName="Meredith",LastName="Alonso", Gender="Female",
                Address ="Stenback", ZipCode=5252, City="Skone", PhoneNumber = 073885599, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19811220-3333, FirstMidName="Arturo",LastName="Anand",Gender="Male",
                Address ="Hardback", ZipCode=5353, City="Gavle", PhoneNumber = 0722445588, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19910918-4444, FirstMidName="Gytis",LastName="Barzdukas",Gender="Female",
                Address ="Seaback", ZipCode=5454, City="Skone", PhoneNumber = 0745678911, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19770605-5555, FirstMidName="Yan",LastName="Li",Gender="Female",
                Address ="Lakeback", ZipCode=5555, City="Stockhlm", PhoneNumber = 077894561, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19880130-6666, FirstMidName="Peggy",LastName="Justice",Gender="Female",
                Address ="Treeback", ZipCode=5656, City="Gothen", PhoneNumber = 079876543, RegistrationDate = DateTime.Parse("2002-09-01")},
            new Patient{SocialSecurityNumber=19900813-7777, FirstMidName="Nino",LastName="Olivetto",Gender="Male",
                Address ="Stenback", ZipCode=5757, City="Gothen", PhoneNumber = 076541237, RegistrationDate = DateTime.Parse("2002-09-01")},
            };

            patients.ForEach(p => context.Patients.AddOrUpdate(s => s.LastName, p));
            context.SaveChanges();

            var departments = new List<Department>
                {
                new Department{DepartmentID=1010, Title= "No department assigned"},
                new Department{DepartmentID=2020, Title= "ICU"},
                new Department{DepartmentID=3030, Title= "Maternity department"},
                new Department{DepartmentID=4040, Title= "Discharge lounge"}
                };

            departments.ForEach(p => context.Departments.AddOrUpdate(s => s.Title, p));
            context.SaveChanges();

            var registrations = new List<Registration>
                {
                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Alexander").ID,
                    DepartmentID = departments.Single(c => c.Title == "ICU" ).DepartmentID,
                    },

                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Alonso").ID,
                    DepartmentID = departments.Single(c => c.Title == "Maternity department" ).DepartmentID,
                    },

                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Barzdukas").ID,
                    DepartmentID = departments.Single(c => c.Title == "Maternity department" ).DepartmentID,
                    },

                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Olivetto").ID,
                    DepartmentID = departments.Single(c => c.Title == "Discharge lounge" ).DepartmentID,
                    },

                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Anand").ID,
                    DepartmentID = departments.Single(c => c.Title == "No department assigned" ).DepartmentID,
                    },

                    new Registration {
                    PatientID = patients.Single(p => p.LastName == "Justice").ID,
                    DepartmentID = departments.Single(c => c.Title == "No department assigned" ).DepartmentID,
                    },
            };


            foreach (Registration r in registrations)
            {
                var registrationInDataBase = context.Registrations.Where
                    (p =>
                           p.Patient.ID == r.PatientID &&
                           p.Department.DepartmentID == r.DepartmentID).SingleOrDefault();
                if (registrationInDataBase == null)
                {
                    context.Registrations.Add(r);
                }
            }
            context.SaveChanges();

        }
    }
}
