using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static CongWebApp.Models.Enumerators;

namespace CongWebApp.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        [Display(Name = "Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(5)]
        public string Suffix { get; set; }
        [Display(Name = "Full Name")]
        [StringLength(60)]
        public string FullName { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public YN Baptised { get; set; }
        [Display(Name = "Date Immersed")]
        [DataType(DataType.Date)]
        public DateTime? DateImmersed { get; set; }
        [Display(Name = "Hope")]
        public Calling Calling { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string Suburb { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [Display(Name = "Postcode")]
        [StringLength(10)]
        public string ZIP { get; set; }
        [Display(Name = "Mobile No.")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Display(Name = "Home No.")]
        [DataType(DataType.PhoneNumber)]
        public string Home { get; set; }
        [Display(Name = "Work No.")]
        [DataType(DataType.PhoneNumber)]
        public string Work { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(200)]
        public string EmailAddress { get; set; }
        [Display(Name = "Assigned Field Service Group")]
        public int? FieldServiceGroupID { get; set; }

        [Display(Name = "Emergency Contact Name")]
        [StringLength(60)]
        public string EcName { get; set; }
        [Display(Name = "Relationship")]
        [StringLength(25)]
        public string EcRelationship { get; set; }
        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber)]
        public string EcMobile { get; set; }
        [Display(Name = "Home")]
        [DataType(DataType.PhoneNumber)]
        public string EcHome { get; set; }
        [Display(Name = "Work")]
        [DataType(DataType.PhoneNumber)]
        public string EcWork { get; set; }

        [Display(Name = "Disaster Contact Name")]
        [StringLength(60)]
        public string DcName { get; set; }
        [Display(Name = "Relationship")]
        [StringLength(25)]
        public string DcRelationship { get; set; }
        [Display(Name = "Mobile")]
        [DataType(DataType.PhoneNumber)]
        public string DcMobile { get; set; }
        [Display(Name = "Home")]
        [DataType(DataType.PhoneNumber)]
        public string DcHome { get; set; }
        [Display(Name = "Work")]
        [DataType(DataType.PhoneNumber)]
        public string DcWork { get; set; }
        [Display(Name = "Special Needs")]
        [StringLength(1000)]
        public string SpecialNeeds { get; set; }
        public int Elderly { get; set; }
        public int Infirm { get; set; }
        public int Blind { get; set; }
        public int Deaf { get; set; }
        [Display(Name = "Assistance Plan")]
        [StringLength(1000)]
        public string AssistancePlan { get; set; }
        [Display(Name = "Houshold Non-Believers")]
        [StringLength(1000)]
        public string NonBelieving { get; set; }
        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public PubStatus Status { get; set; }
        [Display(Name = "Effective Date")]
        [DataType(DataType.Date)]
        public DateTime StatusDate { get; set; }
        [Display(Name = "DC-50 Approved")]
        public YN DC50 { get; set; }
        [Display(Name = "DC-50 Expires")]
        [DataType(DataType.Date)]
        public DateTime? DC50Expiry { get; set; }
        [Display(Name = "Public Witnessing Approved")]
        public YN PublicWitnessing { get; set; }
        [Display(Name = "SMPW Approved")]
        public YN SMPW { get; set; }
        [Display(Name = "Moved In")]
        [DataType(DataType.Date)]
        public DateTime MovedIn { get; set; }
        [Display(Name = "Began Publishing")]
        [DataType(DataType.Date)]
        public DateTime BeginPublisher { get; set; }
        [Display(Name = "Continuous Auxiliary Pioneer")]
        public YN CAP { get; set; }
        [Display(Name = "Family Head")]
        public YN FamilyHead { get; set; }
        [Display(Name = "Family Head Link")]
        public int? FamilyHeadId { get; set; }
        [Display(Name = "Allow Other to see My Contact Details")]
        public YN Visible { get; set; }
        [Display(Name = "Field Service Group")]
        public FieldServiceGroup FieldServiceGroup { get; set; }

    }
}
