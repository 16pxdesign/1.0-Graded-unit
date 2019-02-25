using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Graded_unit.Models
{
    public class Member
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Req")]
        public string Name { get; set; }

        public MemberType MemberType { get; set; }
        public Guardian Guardian { get; set; }


    }
}