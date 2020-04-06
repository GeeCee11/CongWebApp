using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CongWebApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CongWebAppUser class
    public class CongWebAppUser : IdentityUser
    {
        [PersonalData]
        [StringLength(20)]
        public string FirstName { get; set; }
        [PersonalData]
        [StringLength(20)]
        public string LastName { get; set; }
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [PersonalData]
        public string FullName => FirstName + " " + LastName;
    }
}
