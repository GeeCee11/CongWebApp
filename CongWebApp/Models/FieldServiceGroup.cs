using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static CongWebApp.Models.Enumerators;

namespace CongWebApp.Models
{
    public class FieldServiceGroup
    {
        public int FieldServiceGroupID { get; set; }
        [Display(Name = "Group Name")]
        [StringLength(30)]
        public string GroupName { get; set; }
        [StringLength(30)]
        public string Address { get; set; }
        [StringLength(30)]
        public string Suburb { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [Display(Name = "Postcode")]
        [StringLength(10)]
        public string ZIP { get; set; }
        public Days? Day { get; set; }
        [DataType(DataType.Time)]
        public DateTime? Time { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
