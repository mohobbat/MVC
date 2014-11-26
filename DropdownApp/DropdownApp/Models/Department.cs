using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropdownApp.Models
{
    public class Department
    {
        public string code { set; get; }
        public string name { set; get; }
        public int DepartmentId { set; get; }

        public virtual List<Section> Sections { set; get; }
 
    }
}