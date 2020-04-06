using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CongWebApp.Models
{
    public class Enumerators
    {
        public enum Gender
        {
            Female,
            Male
        }

        public enum Calling
        {
            [Display(Name = "N/A")]
            NULL,
            [Display(Name = "Other Sheep")]
            OtherSheep,
            Anointed
        }

        public enum YN
        {
            No,
            Yes
        }

        public enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        public enum PubStatus
        {
            [Display(Name = "Not Publisher")]
            NotPub = 0,
            [Display(Name = "New Publisher")]
            NewPub = 1,
            [Display(Name = "Regular Publisher")]
            RegPub = 2,
            [Display(Name = "Irregular Publisher")]
            IrregPub = 3,
            [Display(Name = "Inactive Publisher")]
            InActive = 4,
            [Display(Name = "Moved Away")]
            Departed = 5,
            [Display(Name = "Deceased")]
            Deceased = 6,
            [Display(Name = "Disfellowshipped")]
            DF = 7
        }

        public enum ServiceAppointment
        {
            [Display(Name = "N/A")]
            NA = 0,
            [Display(Name = "Continuous Auxiliary Pioneer")]
            CAP = 1,
            [Display(Name = "Regular Pioneer")]
            RegPio = 2,
            [Display(Name = "Special Pioneer")]
            SpecPio = 3,
            [Display(Name = "Missionary")]
            Missionary = 4
        }

        public enum ServiceRoles
        {
            [Display(Name = "N/A")]
            NA = 0,
            [Display(Name = "Ministerial Servant")]
            MS = 1,
            [Display(Name = "Elder")]
            E = 2
        }

        public enum ServiceMonths
        {
            [Display(Name = "September", Order = 1)]
            September = 01,
            [Display(Name = "October", Order = 2)]
            October = 02,
            [Display(Name = "November", Order = 3)]
            November = 03,
            [Display(Name = "December", Order = 4)]
            December = 04,
            [Display(Name = "January", Order = 5)]
            January = 05,
            [Display(Name = "February", Order = 6)]
            February = 06,
            [Display(Name = "March", Order = 7)]
            March = 07,
            [Display(Name = "April", Order = 8)]
            April = 02,
            [Display(Name = "May", Order = 9)]
            May = 03,
            [Display(Name = "June", Order = 10)]
            June = 01,
            [Display(Name = "July", Order = 11)]
            July = 11,
            [Display(Name = "August", Order = 12)]
            August = 12,
        }
    }
}
