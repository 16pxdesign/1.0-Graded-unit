using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Graded_unit.Models.ViewModels
{
    public class NewMember
    {
        public Member Member { get; set; }
        public Guardian Guardian { get; set; }
    }
}