using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropdownApp.Models
{
    public class Section
    {
        public string Code { set; get; }
        public string Driscription { get; set; }
        public int SectionId { get; set; }
        public int DepartmentId { set; get; }
        public virtual Department Department { set; get; }
    }
}